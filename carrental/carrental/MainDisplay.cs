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
using carrental.DataModel;
using System.Data.Entity;
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
           
            btmdriveryes.Checked = true;
        }
  
        public int Vehicle_option()
        {         
            string selected_vec = vec_button.SelectedItem.ToString();
            Vechicle vec = new Vechicle(selected_vec);
            int vecChargePerhour = vec.calc_vec(selected_vec);
            return vecChargePerhour;
        }
        public int Basic_operations()
        {
            DateTime RentedDate = dtprented_date.Value;
            DateTime ReturnedDate = dtpreturnedime.Value;
            TimeSpan CountDays = ReturnedDate - RentedDate;
            double Days = CountDays.TotalDays;
           int days_ = Convert.ToInt32(Days);
            return days_;           
        }
        public int Basic_operations_distance()
        {           
            int hireDistance = int.Parse(distance.Text);
            return hireDistance;
        }
        //public int Basic_operations_hirepack() {
        //    string H_Pack=day_hirepackages.SelectedItem.ToString();
        //    Day_package Hipac = new Day_package(H_Pack);
        //    int max_dist = Hipac.Max_km;
        //    return max_dist;
        //}
        public int Basic_operations_Max_Dist()
        {
            string LH_Pack = long_hirepackages.SelectedItem.ToString();
            LongHire Hipac = new LongHire();
            int max_dist = Hipac.Calcm(LH_Pack);
            return max_dist;
        }
        public int Basic_operations_Packprice()
        {
            string LH_Pack = long_hirepackages.SelectedItem.ToString();
            LongHire Hipac = new LongHire();
            int p_rate = Hipac.pac_rate(LH_Pack);
            return p_rate;
        }
       
       
        private void rent_calculate_Click(object sender, EventArgs e)
        {
            string options = comboBox_options.SelectedItem.ToString();
            
            if (options == "Rent")
            {
              
                Rent cal = new Rent(Basic_operations(), Vehicle_option(), btmdriveryes.Checked);
               // cal.time_hire = Convert.ToInt32(Basic_operations());
                //cal.driver = btmdriveryes.Checked;                      ///cal.rent_calculation();
               // cal.vec_Charge_ = Vehicle_option();
                
                total_driver_cost.Text = Convert.ToInt32(cal.drivercost()).ToString();
                total_bill.Text = Convert.ToInt32(cal.Rent_Total()).ToString();

            }

            else if (options == "Day_Hire")
            {
              
                Hire day_cal = new Hire();
              
                day_cal.hire_distance= Convert.ToInt32(Basic_operations_distance());
                day_cal.time_hire = Convert.ToInt32(Basic_operations());
                day_cal.vec_Charge_ = Vehicle_option();
                day_cal.package_distance = Basic_operations_Max_Dist();
                day_cal.package_cost = Basic_operations_Packprice();


                extra_km_charge.Text = day_cal.extraKmCost().ToString();
               waiting_charge.Text = day_cal.WaitTimeCost().ToString();
                base_hire_charge.Text = Convert.ToInt32(day_cal.package_cost).ToString();
                total_bill.Text = Convert.ToInt32(day_cal.total_base_hire_charge_cal()).ToString();
            }

            else if (options == "Long_Hire")
            {
                Hire long_cal = new Hire();
                long_cal.hire_distance = Convert.ToInt32(Basic_operations_distance());
                long_cal.time_hire = Convert.ToInt32(Basic_operations());
                long_cal.package_distance = Basic_operations_Max_Dist();
                total_bill.Text = Convert.ToInt32(long_cal.total_Long_hire_charge_cal()).ToString();
                extra_km_charge_.Text = long_cal.extraKmCost().ToString();
                over_night_charge.Text = long_cal.DriverOverNightRate().ToString();              
            }
            else { MessageBox.Show("Please select on of the packages"); }             
        
        }

        private void addingbtn_Click(object sender, EventArgs e)
        {
            DISTRIBUOR f2 = new DISTRIBUOR(); //
            f2.ShowDialog();                             
        }

    }
}


