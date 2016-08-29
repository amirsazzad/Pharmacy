using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Model.Models;

namespace Pharmacy.Model.Context
{
    public class PharmacyDbContext: DbContext
    {
        public PharmacyDbContext():base("Pharmacy")
        {
            
        }


        public DbSet<Employee> Employees { get; set; }
    }
}
