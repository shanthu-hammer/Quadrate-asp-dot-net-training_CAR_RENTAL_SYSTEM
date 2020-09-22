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
    public partial class BASICCHARGE_EDIT : Form
    {
        public BASICCHARGE_EDIT()
        {
            InitializeComponent();
        }
        //ADD BTN
        private void button6_Click(object sender, EventArgs e)
        {
            basicCharge data = new basicCharge();

     
            Model modelInstance = new Model();
         

            data.OvernightStayCharge = int.Parse(Overnightchr.Text); //getting value from textbox
            data.ExtraKmCharge = int.Parse(extraKmchr.Text);//getting value from textbox
            data.DriverCharge = int.Parse(driverchr.Text);//getting value from textbox


            modelInstance.basicCharges.Add(data);
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
        //DELETE BTN
        private void button5_Click(object sender, EventArgs e)
        {
            Model mod = new Model();
            var da = new vehicle { VehicleId = 1 };
            mod.Entry(da).State = EntityState.Deleted;
            mod.SaveChanges();
        }
    }
}
