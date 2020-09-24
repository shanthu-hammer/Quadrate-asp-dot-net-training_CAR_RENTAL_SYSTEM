using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using carrental.DataModel;
using System.Data.Entity;

namespace carrental
{
    public partial class emponly : UserControl
    {
        public emponly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)///ADD BUTTON
        {
            vehicle data = new vehicle();

            ///var Model = new DatabaseEntities();
            Model modelInstance = new Model();
            ///.vehicle///.AddObject(TableEntityInstance);

            data.VehicleName = Ratehr_vec.Text; ///getting value from textbox
            data.RatePerhour = int.Parse(Ratehr_vec.Text);//getting value from textbox
            data.RatePerNightPark = int.Parse(Nightpar_vec.Text);//getting value from textbox
          
           
            modelInstance.vehicles.Add(data);
            modelInstance.SaveChanges();
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

        private void button2_Click(object sender, EventArgs e)///DELETE BUTTON
        {
           /// vehicle da = new vehicle();

            ///var Model = new DatabaseEntities();
            Model mod = new Model();
           var da = new vehicle { VehicleId= 1 };
          mod.Entry(da).State = EntityState.Deleted;
          mod.SaveChanges();

        }
    }
}
