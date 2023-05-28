using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarWash
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}