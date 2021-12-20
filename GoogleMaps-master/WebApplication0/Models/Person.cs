using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication0.Models
{
    public class Person
    {
        public string Info { get; set; }

        public string Name { get; set; }
        public string Age { get; set; }
        public string FileName { get; set; }

        public double GeoLong { get; set; } 
        public double GeoLat { get; set; }
    }
}
