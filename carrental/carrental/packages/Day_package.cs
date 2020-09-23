using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carrental.DataModel;
namespace carrental
{
    class Day_package
    {
        public string selected_pack;
        public int Max_km;


        public Day_package(string H_Pack)
        {
            selected_pack = H_Pack;

        }
        public int calc_vec()
        {
            Model VC = new Model();

            var vec_Charge = (from vehicle in VC.vehicles
                              where vehicle.VehicleName == selected_pack
                              select vehicle.RatePerhour).FirstOrDefault();
            return Max_km;        
                   }

    }
}

