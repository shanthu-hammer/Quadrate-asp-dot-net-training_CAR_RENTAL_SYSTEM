using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace carrental
{
    public partial class RentCalculation : Form
    {
        public RentCalculation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source= SANTHUJAN\\TEW ; Initial Catalog= carrental; User ID = shanthu; Password= 1234567890;");

        
        
        private void RentCalculation_Load(object sender, EventArgs e)
        {
            dtprented_date.CustomFormat = "dd-MM-yyyy";
           /// dtpreturnedime.CustomFormat = "dd-MM-yyyy";
            btmdriveryes.Checked = true;

        }
        private void Basic_operations()
        {
            double Days = 0;
            DateTime RentedDate = dtprented_date.Value;
            DateTime ReturnedDate = dtpreturnedime.Value;
            bool driver = btmdriveryes.Checked;
        }
        private void rent_calculate_Click(object sender, EventArgs e)
        {
           
         string options = comboBox_options.SelectedItem.ToString();

            if (options == "Rent") {
                rent_calculation(); }
            
            else if (options == "Day_Hire") {
                dayhire_calculation();  }
           
            else if(options == "Long_Hire")
            { longhire_calculation();
             }
            else { }
           
        }

        private void rent_calculation()
        {

            double Days = 0;
            DateTime RentedDate = dtprented_date.Value;
            DateTime ReturnedDate = dtpreturnedime.Value;
            bool driver = btmdriveryes.Checked;



            TimeSpan CountDays = ReturnedDate - RentedDate;
            Days = CountDays.TotalDays;
            ///getting the prices 
            var RatePerDay = 100;
            var RatePerWeek = 600;
            var RatePerMonth = 2900;

            ///getting  the drivers price per day 
            int driver_cost_perday;


            int Weeks = 0;
            int Months = 0;
            int WithoutWkDays = 0;

            int TotDayAmnt = 0;
            int TotWeekAmnt = 0;
            int TotMonthAmnt = 0;

            int DriverCharge = 0;

            float TotalRent = 0;

            if (Days > 6)
            {
                if (Days > 30)
                {
                    Months = Convert.ToInt32(Days / 30);
                 
                    int CountWeeks = Convert.ToInt32(Days - (Months * 30));

                    Weeks = Convert.ToInt32(CountWeeks / 7);
                    WithoutWkDays = Convert.ToInt32(Days - (Weeks * 7) - (Months * 30));

                    TotDayAmnt = WithoutWkDays * RatePerDay;
                    TotWeekAmnt = Weeks * RatePerWeek;
                    TotMonthAmnt = Months * RatePerMonth;

                    TotalRent = TotMonthAmnt + TotWeekAmnt + TotDayAmnt;
                }
                else
                {
                    Weeks = Convert.ToInt32(Days / 7);
                    WithoutWkDays = Convert.ToInt32(Days - (Weeks * 7));


                    TotDayAmnt = WithoutWkDays * RatePerDay;
                    TotWeekAmnt = Weeks * RatePerWeek;

                    TotalRent = TotWeekAmnt + TotDayAmnt;
                }
            }
            else
            {
                TotalRent = Convert.ToInt32(Days * RatePerDay);
                TotDayAmnt = Convert.ToInt32(TotalRent);
                WithoutWkDays = Convert.ToInt32(Days);
            }
            switch (driver)
            {
                case true:
                    DriverCharge = Convert.ToInt32(Days * DriverCharge);
                    break;
                case false:
                    break;
                default:
                    break;
            }



            int TotRentWithDriver = Convert.ToInt32(DriverCharge + TotalRent);
            total_bill.Text = Convert.ToInt32(TotRentWithDriver).ToString();
            total_driver_cost.Text = Convert.ToInt32(DriverCharge).ToString();




        }
        private void dayhire_calculation() {
            


            double Days = 0;
            DateTime RentedDate = dtprented_date.Value;
            DateTime ReturnedDate = dtpreturnedime.Value;
            TimeSpan CountDays = ReturnedDate - RentedDate;
            Days = CountDays.TotalDays;
           
            int time_hired= Convert.ToInt32(Days);
            int cost_per_hour=20;///data from table

            
            int wait_time;
            int package_time = 24;///Data fom table 
            float wait_time_cost=0;

            int hire_distance=200;
            int package_distance=100;///Data fom table 
            int extra_km =0;
            int extra_km_cost=20;///Data fom table 

            int package_cost=1500;///data from table 

            if (time_hired > package_time)
            {
                wait_time = time_hired - package_time;
                wait_time_cost = wait_time * cost_per_hour;
            }
            else if (hire_distance > package_distance)
            {
                extra_km = hire_distance - package_distance;
                extra_km_cost = package_distance * extra_km_cost;
            }
            else { 
            ///messege
            }
            extra_km_charge.Text = extra_km_cost.ToString();
            waiting_charge.Text =wait_time_cost.ToString(); 
           float total_base_hire_charge = Convert.ToInt32(extra_km_cost + wait_time_cost+package_cost);
            
            base_hire_charge.Text = package_cost.ToString();
            total_bill.Text= Convert.ToInt32(total_base_hire_charge).ToString();
        }

        private void longhire_calculation()
        {
            total_driver_cost.Text = Convert.ToInt32(22222).ToString();
        }
    }
}

