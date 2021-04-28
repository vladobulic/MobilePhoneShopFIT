using DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Helpers
{
    public class ConvertToLog
    {
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
    }
}
