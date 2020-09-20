using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carrental;

namespace carrental.DataModel
{
   public class vehicle
    {
  [Key]
        public int VehicleId { get; set; }
      //  [Required]
     //  public string VehicleNo { get; set; }
      //  [Required]
        public string VehicleName { get; set; }
       // [Required]
        public int RatePerDay { get; set; }
       // [Required]
        public int RatePerWeek { get; set; }
       // [Required]
        public int RatePerMonth { get; set; }

        public int RatePerNightPark { get; set; }

       /// public virtual ICollection<Rent> Rents { get; set; }

    }
}
