using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmycDataLib
{
    public class Boat
    {
        public int BoatId { get; set; }
        [Display(Name = "Boat Name")]
        public string BoatName { get; set; }
        public string Picture { get; set; }
        [Display(Name = "Length (In Feet)")]
        public double LengthInFeet { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        [Display(Name = "Creation Date")]
        public DateTime RecordCreationDate { get; set; }
        public ApplicationUser CreatedBy { get; set; }
        [Display(Name = "Created By")]
        public string CreatedByUser { get; set; }

    }
}
