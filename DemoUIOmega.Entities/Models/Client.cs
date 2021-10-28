using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoUIOmega.Entities.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        [DisplayName("Client First Name")]
        public string Firstname { get; set; }
        [DisplayName("Client Last Name")]
        public string Lastname { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Invalide DOB date !")]
        public DateTime DOB { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [StringLength(13)]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Phone number !")]
        [DisplayFormat(DataFormatString = "{0:(###)##-## ## ##}", ApplyFormatInEditMode = true)]
        [DisplayName("Office #")]
        public string Phone { get; set; }

        public GenderType Gender { get; set; }

        public List<Order> Orders { get; set; }

        public bool Active { get; set; }

    }
}
