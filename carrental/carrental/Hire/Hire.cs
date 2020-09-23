using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carrental.DataModel;
using carrental.DataModel;
namespace carrental
{
    class Hire//:Rent
    {
        Model dbHire = new Model();
     

        //int[] pack_details;
        ///public int time_hire;//passin as arguments
        ///public int vec_Charge_;// passin as arguments
        public int time_hire;
        public int vec_Charge_;
        int wait_time;
        public int package_time = 24;///Data fom table 
        public int wait_time_cost;

        public int hire_distance;/// make it accept value from formhire_distance

        public int package_distance;///Data fom table 
        int extra_km;
        public int extra_km_cost;///Data fom table 
        //int km_cost;
        public int Selected_vec_cost;
        public int package_cost;///data from table 

        int cost_per_hour = 20;

       /// public float[] balance = new float[10];
        int Driver_Over_NightRate;
       public int Total_Over_Nights;
        int Per_night_Rate=20;
        int total_Long_hire_charge;
        float total_base_hire_charge; 
        int extra_km_cost_;
      
        public Hire(int a, int b, int c, int d, int e)
        {
            hire_distance = a;
            time_hire = b;
            vec_Charge_ = c;
            package_distance = d;
            package_cost = e;
        }
        public int WaitTimeCost()
        {
            if (time_hire > package_time)
            {
                wait_time = time_hire - package_time;
                wait_time_cost = wait_time * cost_per_hour;
                /// test1=wait_time_cost;
                /// balance[0] = wait_time * cost_per_hour;
                return wait_time_cost;

            }
            else
            {
                wait_time_cost = 0;
                return wait_time_cost;
            }
        }
        public int extraKmCost()
        {
            var km_cost = (from basicCharge in dbHire.basicCharges
                                where basicCharge.StdChrgId == 1
                                select basicCharge.ExtraKmCharge).FirstOrDefault();

            if (hire_distance > package_distance)
            {
                extra_km = hire_distance - package_distance;
                extra_km_cost_ = extra_km * km_cost;
                /// return 
                /// testc= extra_km_cost;
                ///balance[1] = package_distance * extra_km_cost;
                return extra_km_cost_;
            }
            else if (hire_distance<= package_distance)
            {
                extra_km_cost_ = 0;
                return extra_km_cost_;
            }
            extra_km_cost = extra_km_cost_;
            return extra_km_cost;
        }
        public int ToTvechicle(int vec_Charge_, int time_hire)
        {
          
             Selected_vec_cost = time_hire * vec_Charge_;
            return Selected_vec_cost;
        }
        public float total_base_hire_charge_cal()///gives total bill for DAYHIRE 
        {

            total_base_hire_charge = Convert.ToInt32(WaitTimeCost() + extraKmCost() + package_cost+ Selected_vec_cost);//+ ToTvechicle(vec_Charge_, time_hire)
            return total_base_hire_charge;
        }


        // Following code is for calculating LONG HIRE 

        public int DriverOverNightRate()
        {
            Total_Over_Nights = time_hire / 24;
            Driver_Over_NightRate = Total_Over_Nights * Per_night_Rate;
            return Driver_Over_NightRate;
        }

        public float total_Long_hire_charge_cal()///gives total bill for DAYHIRE 
        {

           
            total_Long_hire_charge = Convert.ToInt32(extraKmCost() + DriverOverNightRate() + package_cost); 
            return total_Long_hire_charge;
        }

    }
}

 
