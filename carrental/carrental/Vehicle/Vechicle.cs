using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrental
{
    class Vechicle {
       public string selected_vec_;
        public int vec_Charge;

        public Vechicle(string selected_vec) {
         selected_vec_ = selected_vec;

        }
        public int calc_vec(){    
       if(selected_vec_== "Toyato CHR"){
                vec_Charge = 300;
       return vec_Charge;}
            else if (selected_vec_ == "Tata INNOVA")
            {
                vec_Charge = 350;
                return vec_Charge;
            }
            else if (selected_vec_ == "Alto 800")
            {
                vec_Charge = 400;
                return vec_Charge;
            }
                   return vec_Charge;
       }
   
    }
}

