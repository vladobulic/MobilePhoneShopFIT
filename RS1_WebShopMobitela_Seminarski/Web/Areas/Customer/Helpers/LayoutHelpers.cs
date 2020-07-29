﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Areas.Customer.Models;

namespace Web.Areas.Customer.Helpers
{
    public static class LayoutHelpers
    {
        public static int NotificationCount(HttpContext httpContext)
        {
            return SessionHelper.GetObjectFromJson<List<Item>>(httpContext.Session,  "cart")?.Count ?? 0;
        }
    }
}
