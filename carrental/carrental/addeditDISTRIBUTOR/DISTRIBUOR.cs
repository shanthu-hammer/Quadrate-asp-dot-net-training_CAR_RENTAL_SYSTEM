using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrental
{
    public partial class DISTRIBUOR : Form
    {
        public DISTRIBUOR()
        {
            InitializeComponent();
        }
      //BASIC CHARGES EDIT
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            BASICCHARGE_EDIT f2 = new BASICCHARGE_EDIT(); //
            f2.ShowDialog();
        }
        //VECHICLE EDIT
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            EDIT_VECHICLE f2 = new EDIT_VECHICLE(); //
            f2.ShowDialog();
        }
        //PACKAGES EDIT
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            EDIT f2 = new EDIT(); //
            f2.ShowDialog();
        }
        //CANCEL 
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MainDisplay f2 = new MainDisplay(); //
            f2.ShowDialog();
        }
    }
}
