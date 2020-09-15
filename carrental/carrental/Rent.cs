using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrental
{
    class Rent
    {
        
            public int time_hire;
            public bool driver;
            public int total_DriverCharge;
            public float TotalRent;
            public int TotRentWithDriver;
            int DriverCharge = 100;
            int TotDayAmnt;
            int TotWeekAmnt;
            int TotMonthAmnt;

            int Weeks = 0;
            int Months = 0;
            int WithoutWkDays = 0;




            ///  followed by variables for day and long hire






            ///getting the prices 

        

            // Following code is for calculating RENT
            public float rent_calculation()
            {
                int RatePerDay = 100;
                int RatePerWeek = 600;
                int RatePerMonth = 2900;
                ///getting  the drivers price per day 
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
                return total_DriverCharge;
                /// int TotRentWithDriver = Convert.ToInt32(DriverCharge + TotalRent);
            }
            public int Rent_Total()
            {
                TotRentWithDriver = Convert.ToInt32(total_DriverCharge + TotalRent);

                return TotRentWithDriver;
            }
            // Following code is for calculating DAY HIRE      

        }
    }

