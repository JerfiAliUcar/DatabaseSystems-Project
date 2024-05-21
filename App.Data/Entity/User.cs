using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Data.Entity
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set;}
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}