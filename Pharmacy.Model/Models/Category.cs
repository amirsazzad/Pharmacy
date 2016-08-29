using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Models
{
    public class Category
    {
        public long CategoryId { get; set; }



        public ICollection<Medicine> Medicines { get; set; }
    }
}
