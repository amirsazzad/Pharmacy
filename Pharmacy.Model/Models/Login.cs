using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.Models
{
    class Login
    {
        [Key]
        public long UserId { get; set; }

        public string Username { get; set; }


        public Employee Employee { get; set; }


    }
}
