using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarWash
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CPF { get; set; }
        public string Address { get; set; }
    }
}