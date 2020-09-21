using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace carrental.DataModel
{
    class DayPackage
    {
        [Key]       
        public int PackageId { get; set; }
        public string PName { get; set; }
        public int PDistance { get; set; }
        public int Pcost { get; set; }

    }
}
