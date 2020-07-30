using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Castle.Core.Internal;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Interfaces;
using Web.Areas.Customer.Helpers;
using Web.Areas.Customer.Models;

namespace Web.Areas.Customer.Controllers
{

    [Area("Customer")]
    public class KosaricaController : Controller
    {

        private readonly IMobitelService mobitelService;
        private static readonly string CartName = "cart";

        public KosaricaController(IMobitelService mobitelService)
        {
            this.mobitelService = mobitelService;
        }
        public IActionResult Index()
        {
            KosaricaIndexViewModel model = new KosaricaIndexViewModel();
            model.TotalPrice = 0;
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, CartName);

            
            if (cart.IsNullOrEmpty())
                return RedirectToAction("Index", "Customer", new { area = "Customer" });

            // get all of the data for display view and calculate the total price of the phone
            foreach (var item in cart)
            {
                var mobitel = mobitelService.GetMobitel(item.Product.Id);

                item.Product.mobitel = MobitelViewModel.ConvertToMobitelViewModel(mobitel);
                model.TotalPrice += item.Product.mobitel.Cijena * item.Quantity;
            }
            model.TotalPrice = Converter.RoundToTwoDecimal(model.TotalPrice);
            model.Items = cart;
            return View(model);
            
        }

        public IActionResult Dodaj(int id)
        {

            ProductModel productModel = new ProductModel();
            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, CartName) == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Product = new ProductModel { Id = id }, Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, CartName, cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, CartName);
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Product = new ProductModel { Id = id }, Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            }


            return Ok();
        }

        public IActionResult Brisi(int id)
        {
            if (id != 0)
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, CartName);
                int index = isExist(id);
                if (index != -1)
                {
                    cart.RemoveAt(index);
                    SessionHelper.SetObjectAsJson(HttpContext.Session, CartName, cart);
                }
            }
            return RedirectToAction("Index");
        }


        private int isExist(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, CartName);
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
