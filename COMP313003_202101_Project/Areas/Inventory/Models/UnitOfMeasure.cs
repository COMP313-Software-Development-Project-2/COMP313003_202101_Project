using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace COMP313003_202101_Project.Areas.Inventory.Models
{
    public class UnitOfMeasure
    {
        [Key]
        [Required]
        [Display(Name = "Unit Of Measure Id")]
        public int UnitOfMeasureId { get; set; }
        [Required]
        [Display(Name = "Unit Of Measure Name")]
        public string UnitOfMeasureName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
