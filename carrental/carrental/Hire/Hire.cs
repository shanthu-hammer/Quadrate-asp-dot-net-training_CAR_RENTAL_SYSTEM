﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carrental.DataModel;
namespace carrental
{
    class Hire:Rent
    {

        int wait_time;
        public int package_time = 24;///Data fom table 
        public int wait_time_cost;

        public int hire_distance;/// make it accept value from formhire_distance

        public int package_distance;///Data fom table 
        int extra_km;
        public int extra_km_cost;///Data fom table 
        int km_cost=20;

        public int package_cost = 1500;///data from table 

        int cost_per_hour = 20;

       /// public float[] balance = new float[10];
        int Driver_Over_NightRate;
       public int Total_Over_Nights;
        int Per_night_Rate=20;
        int total_Long_hire_charge;
        float total_base_hire_charge; int extra_km_cost_;
        /// public Hire() { }
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

        public float total_base_hire_charge_cal()///gives total bill for DAYHIRE 
        {

            total_base_hire_charge = Convert.ToInt32(WaitTimeCost() + extraKmCost() + package_cost);
            return total_base_hire_charge;/**/
        }
/**/

        // Following code is for calculating LONG HIRE 

        public int DriverOverNightRate()
        {
            Total_Over_Nights = time_hire / 24;
            Driver_Over_NightRate = Total_Over_Nights * Per_night_Rate;
            return Driver_Over_NightRate;
        }

        public float total_Long_hire_charge_cal()///gives total bill for DAYHIRE 
        {

            ///total_Long_hire_charge = Convert.ToInt32(extra_km_cost + Driver_Over_NightRate + package_cost); extraKmCost()
            total_Long_hire_charge = Convert.ToInt32(extraKmCost() + DriverOverNightRate() + package_cost); 
            return total_Long_hire_charge;
        }

    }
}

 
