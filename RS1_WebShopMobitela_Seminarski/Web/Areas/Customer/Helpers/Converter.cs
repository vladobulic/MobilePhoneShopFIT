using DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Customer.Helpers
{
    public static class Converter
    {
        public static List<SelectListItem> ConvertToSelectListItem(IEnumerable<Proizvodjac> lista)
        {
            return lista.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Naziv
            }).ToList();
        }


        public static Log CreateLog(Exception exception, UserManager<ApplicationUser> _userManager, HttpContext httpContext, string pathString)
        {
            return new Log
            {
                StackTrace = exception.StackTrace,
                TimeStamp = Convert.ToDateTime(exception.Data["DateTimeInfo"]),
                Message = exception.Message,
                User = _userManager.GetUserId(httpContext.User),
                ActionDescriptor = exception.TargetSite.ToString(),
                Type = exception.HResult.ToString(),
                IpAddress = httpContext.Connection.RemoteIpAddress.ToString(),
                Source = pathString,
                RequestId = Activity.Current?.Id ?? httpContext.TraceIdentifier,
                RequestPath = httpContext.Request.Path
            };
        }

        public static double RoundToTwoDecimal(double d) => Math.Round(d, 2);
    }
}
