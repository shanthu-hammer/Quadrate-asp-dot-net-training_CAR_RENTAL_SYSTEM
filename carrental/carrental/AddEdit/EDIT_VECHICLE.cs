using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using carrental.DataModel;
using System.Data.Entity;

namespace carrental
{
    public partial class EDIT_VECHICLE : Form
    {
        public EDIT_VECHICLE()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

          
         
            vehicle data = new vehicle();

            ///var Model = new DatabaseEntities();
            Model modelInstance = new Model();
            ///.vehicle///.AddObject(TableEntityInstance);

            data.VehicleName = vec_name.Text; ///getting value from textbox
            data.RatePerhour = int.Parse(hourrat.Text);//getting value from textbox
            data.RatePerNightPark = int.Parse(Nightpar_vec.Text);//getting value from textbox


            modelInstance.vehicles.Add(data);
            ///modelInstance.SaveChanges();
            int res = modelInstance.SaveChanges();

            if (res > 0)
            {


                MessageBox.Show("Data Inserted Successfully");
            }
            else
            {

                MessageBox.Show("Try Again!!!");

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Model mod = new Model();
            var da = new vehicle { VehicleId = 1 };
            mod.Entry(da).State = EntityState.Deleted;
            mod.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewgrid_Click(object sender, EventArgs e)
        {
            Model che = new Model();
            var ForView = from vehicle in che.vehicles

                           select vehicle;
            dataGridView1.DataSource = ForView.ToList();
            
        }
    }
}
