using AIMS_Portal.Features.Companies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AIMS_Portal.Features.Deliverable
{
    public class Job
    {
        public int JobId { get; set; }

        [Required]
        public string JobName { get; set; }

        [Required]
        public Company CompanyName { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTimeOffset DateCompleted { get; set; } 
    }
}
