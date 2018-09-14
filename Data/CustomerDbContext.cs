using CustomersAppMvcAspCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomersAppMvcAspCore.Data
{
    public class CustomerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-7BGFQJH;Database=MVCcustomer;Trusted_Connection=True;");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
