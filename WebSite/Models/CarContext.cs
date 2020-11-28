using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class CarContext: DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Car> Cars { get; set; } //набор Car
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Car>().HasKey(u => u.CarId);
            modelBuilder.Entity<Car>().Property(b => b.Model)
                .IsRequired()
                .HasMaxLength(150);

            modelBuilder.Entity<CarOrder>()
                .HasKey(x => x.CarOrderId);

            modelBuilder.Entity<CarOrder>()
                .HasOne(x => x.Car)
                .WithMany(m => m.Orders)
                .HasForeignKey(x => x.CarId);

            modelBuilder.Entity<CarOrder>()
                .HasOne(x => x.Order)
                .WithMany(m => m.Cars)
                .HasForeignKey(x => x.OrderId);


            modelBuilder.Entity<User>().HasKey(x => x.UserId);
            modelBuilder.Entity<Order>().HasKey(x => x.OrderId);

            modelBuilder.Entity<User>()
                .HasMany(m => m.Orders)
                .WithOne(k => k.User)
                .HasForeignKey(k => k.UserId);

        }
    }
}
