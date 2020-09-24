using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carrental.DataModel;
namespace carrental
{
    class PackageSelector
    {
        public string selected_pack;
        public int pack_cost;

        public PackageSelector(string Pack) {
            selected_pack = Pack;
          
        }
        //public int Package_Selector(string Pack)
        //{
        //    Model PC = new Model();
        //    var vec_Charge = (from vehicle in VC.vehicles
        //                      where vehicle.VehicleName == selected_pack
        //                      select vehicle.RatePerhour).FirstOrDefault();
        //    return Max_km;
        //}

        }
}
