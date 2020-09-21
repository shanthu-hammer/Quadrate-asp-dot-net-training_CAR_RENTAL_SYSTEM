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
            int vecChargePerhour = vec.calc_vec();
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
        public int Basic_operations_hirepack() {
            string H_Pack=day_hirepackages.SelectedItem.ToString();
            Day_package Hipac = new Day_package(H_Pack);
            int max_dist = Hipac.Max_km;
            return max_dist;
        }
        public int Basic_operations_Longhirepack()
        {
            string LH_Pack = long_hirepackages.SelectedItem.ToString();
            Day_package Hipac = new Day_package(LH_Pack);
            int max_dist = Hipac.Max_km;
            return max_dist;
        }
        //public void addingdata() {
        //    vehicle data = new vehicle();

        //    ///var Model = new DatabaseEntities();
        //    Model modelInstance = new Model();
        //    ///.vehicle///.AddObject(TableEntityInstance);
            
        //    data.VehicleName = "innova";
        //    data.RatePerhour = 100;
        //    data.RatePerNightPark = 25;
        //    //this.Model.vehicle.AddObject(vehicle);
        //    /// Model.vehicles.Add(data);
        //    modelInstance.vehicles.Add(data);
        //    modelInstance.SaveChanges();
            
        //}
        private void rent_calculate_Click(object sender, EventArgs e)
        {
            string options = comboBox_options.SelectedItem.ToString();
            
            if (options == "Rent")
            {
              
                Rent cal = new Rent();
                cal.time_hire = Convert.ToInt32(Basic_operations());
                cal.driver = btmdriveryes.Checked;                      ///cal.rent_calculation();
                cal.vec_Charge_ = Vehicle_option();
                total_bill.Text = Convert.ToInt32(cal.Rent_Total()).ToString();
                total_driver_cost.Text = Convert.ToInt32(cal.drivercost()).ToString();
               
            }

            else if (options == "Day_Hire")
            {
              
                Hire day_cal = new Hire();
              
                day_cal.hire_distance= Convert.ToInt32(Basic_operations_distance());
                day_cal.time_hire = Convert.ToInt32(Basic_operations());
                day_cal.vec_Charge_ = Vehicle_option();
                day_cal.package_distance = Basic_operations_hirepack();
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
                long_cal.package_distance = Basic_operations_Longhirepack();
                total_bill.Text = Convert.ToInt32(long_cal.total_Long_hire_charge_cal()).ToString();
                extra_km_charge_.Text = long_cal.extraKmCost().ToString();
                over_night_charge.Text = long_cal.DriverOverNightRate().ToString();              
            }
            else { MessageBox.Show("Please select on of the packages"); }
        
        
        
        }

        private void addingbtn_Click(object sender, EventArgs e)
        {
        
           
                vehicle data = new vehicle();

                ///var Model = new DatabaseEntities();
                Model modelInstance = new Model();
            ///.vehicle///.AddObject(TableEntityInstance);

            //data.VehicleName = "innova";
            //data.RatePerhour = 100;
            //data.RatePerNightPark = 25;
            ////this.Model.vehicle.AddObject(vehicle);
            ///// Model.vehicles.Add(data);
            //modelInstance.vehicles.Add(data);
            //modelInstance.SaveChanges();
            Model mod = new Model();
            var da = new vehicle { VehicleId = 2 };
            mod.Entry(da).State = EntityState.Deleted;
            mod.SaveChanges();


        }

        //    private void distance_TextChanged(object sender, EventArgs e)
        //    {

        //    }
    }
}


