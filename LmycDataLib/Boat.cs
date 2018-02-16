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
        [Key]
        [MaxLength(30)]
        public String BoatId { get; set; }

        [MaxLength(30)]
        public string BoatName { get; set; }

        [MaxLength(30)]
        public string Picture { get; set; }

        public int LengthInFeet { get; set; }

        [MaxLength(30)]
        public string Make { get; set; }

        public int Year { get; set; }

        public DateTime RecordCreationDate { get; set; }

        public String CreatedBy { get; set; }

    }
}
