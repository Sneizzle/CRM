using CRM.Shared.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace CRMApi
{
    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions<CRMContext> options)
           : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}
