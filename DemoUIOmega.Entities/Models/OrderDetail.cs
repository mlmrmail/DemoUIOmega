using System;
using System.Collections.Generic;
using System.Text;

namespace DemoUIOmega.Entities.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public bool Active { get; set; }


    }
}
