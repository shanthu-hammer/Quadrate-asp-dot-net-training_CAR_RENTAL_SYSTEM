using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carrental.DataModel;
namespace carrental
{
    class LongHire
    {
        Model LHC = new Model();
        public string selected_Lpack;
        public int Max_km;
        public int p_rate;
        public LongHire(string LH_Pack)
        {
            selected_Lpack = LH_Pack;

        }

        public int Calcm(string LH_Pack)
        {
            // Model LHC = new Model();
            selected_Lpack = LH_Pack;
            var Max_km_ = (from DayPackage in LHC.DayPackages
                          where DayPackage.PName == selected_Lpack
                              select DayPackage.PDistance).FirstOrDefault();
            Max_km = Max_km_;


            return Max_km;
        }
        public int pac_rate() {
            var p_rate = (from DayPackage in LHC.DayPackages
                          where DayPackage.PName == selected_Lpack
                          select DayPackage.Pcost).FirstOrDefault();

            return p_rate;
        }
    }
}

