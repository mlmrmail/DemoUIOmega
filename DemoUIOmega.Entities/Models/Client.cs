using System;
using System.Collections.Generic;
using System.Text;

namespace DemoUIOmega.Entities.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public GenderType Gender { get; set; }

        public List<Order> Orders { get; set; }

        public bool Active { get; set; }

    }
}
