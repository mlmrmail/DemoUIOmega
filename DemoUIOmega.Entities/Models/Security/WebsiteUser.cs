using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoUIOmega.Entities.Models.Security
{
    public class WebsiteUser : IdentityUser
    {
        public string UserHandle { get; set; }
    }
}
