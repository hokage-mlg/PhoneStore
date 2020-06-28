using Microsoft.EntityFrameworkCore;
using PhoneStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<DeliveryDetails> DeliveryDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
