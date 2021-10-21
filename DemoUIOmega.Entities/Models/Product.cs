using System;
using System.Collections.Generic;
using System.Text;

namespace DemoUIOmega.Entities.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public bool Active { get; set; }
    }
}
