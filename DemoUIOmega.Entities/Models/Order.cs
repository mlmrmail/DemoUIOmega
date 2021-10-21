using System;
using System.Collections.Generic;
using System.Text;

namespace DemoUIOmega.Entities.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public List<OrderDetail> Details { get; set; }

        public int ClientId { get; set; }
        public bool Active { get; set; }
    }
}
