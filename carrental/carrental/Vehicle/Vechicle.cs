using carrental.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carrental.DataModel;
using System.Data.Entity;
using System.Runtime.InteropServices;

namespace carrental
{
    class Vechicle {

        //Model MP = new Model();
        //int a= (from vehicle in Model
        //        where vehicle.JobID == QJobID
        //        select jlist).ToList();
        public string selected_vec_;
        public int vec_Charge;

        public Vechicle(string selected_vec) {
         selected_vec_ = selected_vec;

        }
        public int calc_vec(){
            Model VC = new Model();

            var vec_Charge = (from vehicle in VC.vehicles
                                where vehicle.VehicleName == selected_vec_
                                select vehicle.RatePerhour).FirstOrDefault();   
                   return vec_Charge;
       }
   
    }
}

