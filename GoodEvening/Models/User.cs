using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GoodEvening.Models
{
    public class User
    {
        public int id { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
    }
}
