using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Models
{
    public class Medicine
    {
        public long MedicineId { get; set; }

        public virtual Category Category { get; set; }
    }
}
