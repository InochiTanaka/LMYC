using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmycDataLib
{
<<<<<<< HEAD
    public class Boat
=======
    class Boat
>>>>>>> 67362475ad8795fcdb1105a95eea6d5e4c22018a
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

<<<<<<< HEAD
        public int Year { get; set; }
=======
        public DateTime Year { get; set; }
>>>>>>> 67362475ad8795fcdb1105a95eea6d5e4c22018a

        public DateTime RecordCreationDate { get; set; }

        public String CreatedBy { get; set; }

    }
}
