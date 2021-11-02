using DemoUIOmega.Entities.Models.Security;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoUIOmega.Entities.Models.Context
{
    public class AuthenticationContext : IdentityDbContext<WebsiteUser>
    {
        //public AuthenticationContext(DbContextOptions<AuthenticationContext> options) : base(options)
        //{

        //}

    }
}
