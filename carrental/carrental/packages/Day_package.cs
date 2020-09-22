using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrental
{
    class Day_package
    {
        public string selected_pack;
        public int Max_km;


        public Day_package(string H_Pack)
        {
            selected_pack = H_Pack;

        }
        public int calc_vec()
        {

            if (selected_pack == "Airport")
            {
                Max_km = 100;
                return Max_km;
            }
            else if (selected_pack == "Postoffice")
            {
                Max_km = 200;
                return Max_km;
            }
            else if (selected_pack == "Town")
            {
                Max_km = 300;
                return Max_km;
            }
            else if (selected_pack == "Colombo")
            {
                Max_km = 400;
                return Max_km;
            }
            return Max_km;


        }

    }
}

