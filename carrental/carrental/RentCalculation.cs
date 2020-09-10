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
        SqlConnection con = new SqlConnection("Data Source= SANTHUJAN\\TEW ; Initial Catalog= carrental; User ID = shanthu; Password= 1234567890;");



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
        private void rent_calculate_Click(object sender, EventArgs e)
        {

           

            string options = comboBox_options.SelectedItem.ToString();
            calculation cal = new calculation();
            if (options == "Rent") {
                ///rent_calculation()
                cal.time_hire = Convert.ToInt32(Basic_operations());
                cal.driver= btmdriveryes.Checked;
                cal.rent_calculation();
              
               total_bill.Text = Convert.ToInt32(cal.Total()).ToString();
               total_driver_cost.Text = Convert.ToInt32(cal.rent_calculation()).ToString();

            }

            else if (options == "Day_Hire") {
                ///dayhire_calculation();
                ///cal.dayhire_calculations();
                calculation day_cal = new calculation();
                extra_km_charge.Text = day_cal.extraKmCost().ToString();
                waiting_charge.Text = day_cal.WaitTimeCost().ToString();
               /// dayhire_calculation();

               /// base_hire_charge.Text = (1500).ToString();
               total_bill.Text = Convert.ToInt32(day_cal.total_base_hire_charge_cal()).ToString();
            }

            else if (options == "Long_Hire")
            {
                ///cal.longhire_calculation();
            }
            else { MessageBox.Show("Please select on of the packages"); }

        }
        public void values_for_cal(){
            double Days = 0;
            DateTime RentedDate = dtprented_date.Value;
            DateTime ReturnedDate = dtpreturnedime.Value;
            TimeSpan CountDays = ReturnedDate - RentedDate;
            
            

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

            int DriverCharge = 100;

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
               /// return TotalRent;
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
        public void dayhire_calculation() {
            


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

            if (time_hired <= 24)
            {
                if (time_hired > package_time)
                {
                    wait_time = time_hired - package_time;
                    wait_time_cost = wait_time * cost_per_hour;
                }
                 if (hire_distance > package_distance)
                {
                    extra_km = hire_distance - package_distance;
                    extra_km_cost = package_distance * extra_km_cost;
                }
                else
                {
                    ///messege
                }
            }
            else {
                longhire_calculation(); 
            }
            extra_km_charge.Text = extra_km_cost.ToString();
            waiting_charge.Text =wait_time_cost.ToString(); 
           float total_base_hire_charge = Convert.ToInt32(extra_km_cost + wait_time_cost+package_cost);
            
            base_hire_charge.Text = package_cost.ToString();
            total_bill.Text= Convert.ToInt32(total_base_hire_charge).ToString();
        }

        private void longhire_calculation()
        {



           
        }
    }
}


class calculation///: RentCalculation
{
    public int time_hire=25;
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



    /// <summary>
    ///  below  variables for day hire
    /// </summary>




    int wait_time;
    public int package_time = 24;///Data fom table 
    public int wait_time_cost;

    int hire_distance = 200;
    int package_distance = 100;///Data fom table 
    int extra_km = 0;
    public int extra_km_cost = 20;///Data fom table 

    public int package_cost = 1500;///data from table 

    int cost_per_hour = 20;
   
    public float[] balance = new float[10];



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
    public int Total()
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

    public float total_base_hire_charge_cal( )///gives total bill for DAYHIRE 
    {
       
           total_base_hire_charge = Convert.ToInt32(extra_km_cost + wait_time_cost + package_cost);
        return total_base_hire_charge;
    }

   

   
    public void longhire_calculation()
    {

    }
    


}