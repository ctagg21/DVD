using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarMastery.Models.Tables;

namespace Data
{
    public class CarEntities : DbContext
    {
        public CarEntities() : base("guildCars")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<ContactInquiry> ContactInquiries { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<PurchaseType> PurchaseTypes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Model> Models { get; set; }

    }
}
