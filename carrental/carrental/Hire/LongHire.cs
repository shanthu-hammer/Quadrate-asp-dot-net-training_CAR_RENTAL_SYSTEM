using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrental
{
    class LongHire
    {
        public string selected_Lpack;
        public int Max_km;
        public LongHire(string LH_Pack)
        {
            selected_Lpack = LH_Pack;
        }

        public int Calcm()
        {
            if (selected_Lpack == "ooty")
            {
                Max_km = 500;
                return Max_km;
            }
            else if (selected_Lpack == "kodaikanal")
            {
                Max_km = 700;
                return Max_km;
            }
            else if (selected_Lpack == "Batti")
            {
                Max_km = 800;
                return Max_km;
            }
            else if (selected_Lpack == "Jaffna")
            {
                Max_km = 900;
                return Max_km;
            }
            return Max_km;


        }

    }
}

