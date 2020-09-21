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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            DayPackage P= new DayPackage();

            ///var Model = new DatabaseEntities();
            Model MP = new Model();
            ///.vehicle///.AddObject(TableEntityInstance);

            P.PName = Package_Name.Text;///Ratehr_vec.Text; ;///getting value from textbox
            P.PDistance = int.Parse(Package_Distance.Text);//getting value from textbox
            P.Pcost = int.Parse(Package_Cost.Text);//getting value from textbox


            MP.DayPackage.Add(P);
            MP.SaveChanges();
            int res = MP.SaveChanges();

            if (res > 0)
            {


                MessageBox.Show("Data Inserted Successfully");
            }
            else
            {

                MessageBox.Show("Try Again!!!");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Model mod = new Model();
            var da = new DayPackage { PackageId = 1 };
            mod.Entry(da).State = EntityState.Deleted;
            mod.SaveChanges();
        }
    }
}
