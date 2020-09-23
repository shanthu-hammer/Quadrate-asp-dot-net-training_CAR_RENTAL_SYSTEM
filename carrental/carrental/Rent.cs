using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using carrental.DataModel;
using carrental.DataModel;
using System.Data.Entity;
namespace carrental

{
    class Rent
    {
       
        Model dbbb = new Model();
        int Selected_vec_cost;
        public int vec_Charge_;
        public int time_hire;
        public bool driver;
        public int total_DriverCharge;
        public float TotalRent;
        public int TotRentWithDriver;
        int DriverCharge;
        //var daaa = (from basicCharge in dbbb.basicCharges
        //            where basicCharge.StdChrgId == 1
        //            select basicCharge.DriverCharge).FirstOrDefault();


        //Model.basicCharge.Where(basicCharge.StdChrgId == "1")




        int TotDayAmnt;
        int TotWeekAmnt;
        int TotMonthAmnt;
       
        int Weeks = 0;
        int Months = 0;
        int WithoutWkDays = 0;

        //public Rent(int Days){}
       
            public float rent_calculation() 
            // Following code is for calculating RENT
        {
            
            
            int RatePerDay = 100; ///getting  the drivers price per day 
                int RatePerWeek = 600;
                int RatePerMonth = 2900;
               
                int driver_cost_perday;

                if (time_hire > 6)
                {
                    if (time_hire > 30)
                    {
                        Months = Convert.ToInt32(time_hire / 30);
                        int CountWeeks = Convert.ToInt32(time_hire - (Months * 30));
                         Weeks = Convert.ToInt32(CountWeeks / 7);
                        WithoutWkDays = Convert.ToInt32(time_hire - (Weeks * 7) - (Months * 30));
                        TotDayAmnt = WithoutWkDays * RatePerDay;
                        TotWeekAmnt = Weeks * RatePerWeek;
                        TotMonthAmnt = Months * RatePerMonth;
                        TotalRent = TotMonthAmnt + TotWeekAmnt + TotDayAmnt;
                        return TotalRent;
                        ///
                    }
                    else
                    {
                        Weeks = Convert.ToInt32(time_hire / 7);
                        WithoutWkDays = Convert.ToInt32(time_hire - (Weeks * 7));

                    //int select_vec_charg = vec_Charge_ * time_hire;
                        TotDayAmnt = WithoutWkDays * RatePerDay;
                        TotWeekAmnt = Weeks * RatePerWeek;
                        
                        TotalRent = TotWeekAmnt + TotDayAmnt;
                        return TotalRent;
                    }
                }
                else
                {
                    TotalRent = Convert.ToInt32(time_hire * RatePerDay);
                    TotDayAmnt = Convert.ToInt32(TotalRent);
                    WithoutWkDays = Convert.ToInt32(time_hire);
                }
            return TotalRent;              
            }
        public int drivercost()
        {
            var DriverCharge = (from basicCharge in dbbb.basicCharges
                        where basicCharge.StdChrgId == 1
                        select basicCharge.DriverCharge).FirstOrDefault();
          //  DriverCharge = daaa;

            switch (driver)
            {
                case true:
                    total_DriverCharge = Convert.ToInt32(time_hire * DriverCharge);
                    return total_DriverCharge;
                    break;
                case false:
                    total_DriverCharge = 0;
                    return total_DriverCharge;
                    break;
                default:
                    break;

            }
            total_DriverCharge = time_hire * DriverCharge;
            return total_DriverCharge;
        }
        public int ToTvechicle(int vec_Cha_,int time_hire_) {
            /// vec_cost Vech = new vec_cost(time_hire,vec_Charge_;);
            int Selected_vec_cost = time_hire_ * vec_Cha_;
            return Selected_vec_cost;
        }
            public int Rent_Total()
            {
                TotRentWithDriver = Convert.ToInt32(drivercost() + rent_calculation() + ToTvechicle(vec_Charge_, time_hire));
                return TotRentWithDriver;
            }         
       }
    }

