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
using System.Security.Cryptography.X509Certificates;

namespace carrental
{
    public partial class RentCalculation : Form
    {
        public RentCalculation()
        {
            InitializeComponent();
        }
       /// SqlConnection con = new SqlConnection("Data Source= SANTHUJAN\\TEW ; Initial Catalog= carrental; User ID = shanthu; Password= 1234567890;");



        private void RentCalculation_Load(object sender, EventArgs e)
        {
            dtprented_date.CustomFormat = "dd-MM-yyyy";
            /// dtpreturnedime.CustomFormat = "dd-MM-yyyy";
            btmdriveryes.Checked = true;

        }
        public double Basic_operations()
        {
            DateTime RentedDate = dtprented_date.Value;
            DateTime ReturnedDate = dtpreturnedime.Value;
            TimeSpan CountDays = ReturnedDate - RentedDate;
            double Days = CountDays.TotalDays;
            return Days;

        }
        ///public int Basic_operations_distance()
       /// {
          ///  int hire_distance = distance.Text;
         ///   return distance;

       /// }
        private void rent_calculate_Click(object sender, EventArgs e)
        {



            string options = comboBox_options.SelectedItem.ToString();
            calculation cal = new calculation();
            if (options == "Rent")
            {


                cal.time_hire = Convert.ToInt32(Basic_operations());
                cal.driver = btmdriveryes.Checked;
                cal.rent_calculation();

                total_bill.Text = Convert.ToInt32(cal.Rent_Total()).ToString();
                total_driver_cost.Text = Convert.ToInt32(cal.rent_calculation()).ToString();
                base_hire_charge.Text = Convert.ToInt32(cal.package_cost).ToString();
            }

            else if (options == "Day_Hire")
            {
                calculation day_cal = new calculation();
                day_cal.time_hire = Convert.ToInt32(Basic_operations());               
                extra_km_charge.Text = day_cal.extraKmCost().ToString();
                waiting_charge.Text = day_cal.WaitTimeCost().ToString();



                total_bill.Text = Convert.ToInt32(day_cal.total_base_hire_charge_cal()).ToString();
            }

            else if (options == "Long_Hire")
            {
                calculation long_cal = new calculation();
                long_cal.time_hire = Convert.ToInt32(Basic_operations());
                total_bill.Text = Convert.ToInt32(long_cal.total_Long_hire_charge_cal()).ToString();
                extra_km_charge_.Text = long_cal.extraKmCost().ToString();
                over_night_charge.Text = long_cal.DriverOverNightRate().ToString();
              
            }
            else { MessageBox.Show("Please select on of the packages"); }

        }
    }
}


class calculation///: RentCalculation
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





    int wait_time;
    public int package_time = 24;///Data fom table 
    public int wait_time_cost;

    int hire_distance = 200;/// make it accept value from form
    
    int package_distance = 100;///Data fom table 
    int extra_km = 0;
    public int extra_km_cost = 20;///Data fom table 

    public int package_cost = 1500;///data from table 

    int cost_per_hour = 20;

    public float[] balance = new float[10];
    int Driver_Over_NightRate;
    int Total_Over_Nights;
    int Per_night_Rate;
    int total_Long_hire_charge;


    ///getting the prices 

    float total_base_hire_charge;

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
            extra_km_cost = package_distance * extra_km_cost;
            /// return 
            /// testc= extra_km_cost;
            ///balance[1] = package_distance * extra_km_cost;
            return extra_km_cost;
        }
        else
        {
            extra_km_cost = 0;

        }

        return extra_km_cost;
    }

    public float total_base_hire_charge_cal()///gives total bill for DAYHIRE 
    {

        total_base_hire_charge = Convert.ToInt32(extra_km_cost + wait_time_cost + package_cost);
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

        total_Long_hire_charge = Convert.ToInt32(extra_km_cost + Driver_Over_NightRate + package_cost);
        return total_Long_hire_charge;
    }

}