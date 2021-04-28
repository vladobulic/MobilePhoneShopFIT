﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Models
{
    public class BanKupcaViewModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime datumDo { get; set; }
        public bool zauvijek { get; set; }
        [Required]
        public string razlog { get; set; }
    }
}
