using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace carrental.DataModel
{
    class basicCharges
    {
        [Key]
        public int StdChrgId { get; set; }
        [Required]
        public int PackageId { get; set; }
       /// public virtual Package Packages { get; set; }
        //[Required]
       // public DateTime StartDate { get; set; }
       /// [Required]
       /// public DateTime EndDate { get; set; }
       /// [Required]
       /// public int tot_Km { get; set; }
       /// [Required]
       /// public int { get; set; }
        public int? VehicleId { get; set; }
      ///  public virtual Driver Driver { get; set; }
     
        ///[Required]
        ///public int HireCharge { get; set; }
        public int OvernightStayCharge { get; set; }
        public int ExtraKmCharge { get; set; }
        ///[Required]
        public int DriverCharge { get; set; }

    }
}
