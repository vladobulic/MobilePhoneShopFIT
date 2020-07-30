using DataAccessLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Web.Areas.Customer.Controllers;
using Web.Areas.Customer.Models;

namespace Tests.TestsMethods
{
    public class CustomerIndexPageTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMobitelServiceAndRepository()
        {
            
            var mobitelService = new Mock<IMobitelService>();
            var proizvodjacService = new Mock<IProizvodjacService>();
            var logService = new Mock<ILogService>();
            var novostiService = new Mock<INovostiService>();
            var emailService = new Mock<IEmailService>();





            CustomerController customerController = new CustomerController(mobitelService.Object, proizvodjacService.Object, logService.Object, null, novostiService.Object, emailService.Object);

            
            var ivm = new IndexViewModel
            {
                Page = 1,
                PriceTo = 1200,
                TotalPages = 3,
                Mobiteli = MobitelViewModel.ConvertToMobitelViewModel(mobitelService.Object.GetMobiteli())
            };
            

            var result = customerController.Index(ivm);

            Assert.IsInstanceOf<ActionResult>(result);

            

        }
    }
}
