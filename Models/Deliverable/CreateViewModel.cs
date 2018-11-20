using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AIMS_Portal.Models.Deliverable
{
    public class CreateViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Job Name is required.")]
        public string JobName { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTimeOffset DateCompleted { get; set; }
    }
}
