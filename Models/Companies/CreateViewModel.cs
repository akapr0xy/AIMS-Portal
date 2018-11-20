using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AIMS_Portal.Models.Companies
{
    public class CreateViewModel
    {
        public int Id { get; set; }

        [Required]
        public string CompanyName { get; set; }
    }
}
