using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel.Management.System.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Salary { get; set; }
        public DateTime JoinDateTime { get; set; }
        public bool Status { get; set; }
    }
}