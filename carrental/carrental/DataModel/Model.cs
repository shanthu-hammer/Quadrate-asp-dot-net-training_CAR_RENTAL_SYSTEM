using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrental.DataModel
{
    class Model : DbContext
    {

        public Model() : base("con") { }
            public DbSet<vehicle> vehicles { get; set; }
            //public DbSet<Rent> Rents { get; set; }
           /// public DbSet<Driver> Drivers { get; set; }
          ///  public DbSet<LongHire> LongHire { get; set; }
           /// public DbSet<DayPackage> DayPackage { get; set; }
          /// public DbSet<LongHire> LongHires { get; set; }
            ///public DbSet<User> Users { get; set; }
        
    }
}
