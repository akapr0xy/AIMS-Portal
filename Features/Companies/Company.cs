﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AIMS_Portal.Features.Companies
{
    public class Company
    {
        public int CompanyId { get; set; }

        [Required]
        public string CompanyName { get; set; }
    }
}
