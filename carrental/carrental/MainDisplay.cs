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
///using ForCalculation;

namespace carrental
{
    public partial class MainDisplay : Form
    {
        public MainDisplay()
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
            Rent cal = new Rent();
            if (options == "Rent")
            {


                cal.time_hire = Convert.ToInt32(Basic_operations());
                cal.driver = btmdriveryes.Checked;
                cal.rent_calculation();

                total_bill.Text = Convert.ToInt32(cal.Rent_Total()).ToString();
                total_driver_cost.Text = Convert.ToInt32(cal.rent_calculation()).ToString();
                ///base_hire_charge.Text = Convert.ToInt32(cal.package_cost).ToString();
            }

            else if (options == "Day_Hire")
            {
                Day_Hire day_cal = new Day_Hire();
                day_cal.time_hire = Convert.ToInt32(Basic_operations());               
                extra_km_charge.Text = day_cal.extraKmCost().ToString();
               waiting_charge.Text = day_cal.WaitTimeCost().ToString();
                base_hire_charge.Text = Convert.ToInt32(day_cal.package_cost).ToString();


                total_bill.Text = Convert.ToInt32(day_cal.total_base_hire_charge_cal()).ToString();
            }

            else if (options == "Long_Hire")
            {
                Day_Hire long_cal = new Day_Hire();
                long_cal.time_hire = Convert.ToInt32(Basic_operations());
                total_bill.Text = Convert.ToInt32(long_cal.total_Long_hire_charge_cal()).ToString();
                extra_km_charge_.Text = long_cal.extraKmCost().ToString();
                over_night_charge.Text = long_cal.DriverOverNightRate().ToString();
              
            }
            else { MessageBox.Show("Please select on of the packages"); }

        }
    }
}


