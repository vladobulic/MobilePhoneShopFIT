﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Classes.Helper
{
   public class MailRequest
    {
        public string ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
