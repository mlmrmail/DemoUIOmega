using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoUIOmega.Entities.Models
{
    [Table("OmegaClients")]
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [DisplayName("Client First Name")]
        public string Firstname { get; set; }
        [DisplayName("Client Last Name")]
        public string Lastname { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public GenderType Gender { get; set; }

        public List<Order> Orders { get; set; }

        public bool Active { get; set; }

    }
}
