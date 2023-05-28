using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarWash
{
    public class CarWashRecord
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string WashType { get; set; }
        public decimal Price { get; set; }
    }
}