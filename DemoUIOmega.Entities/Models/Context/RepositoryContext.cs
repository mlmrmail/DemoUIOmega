using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoUIOmega.Entities.Models.Context
{
    public class RepositoryContext : DbContext
    {

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        

        public DbSet<Client> Clients { get; set; }

    }
}
