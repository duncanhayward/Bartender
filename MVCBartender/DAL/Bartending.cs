using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBartender.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MVCBartender.DAL
{
    public class Bartending : DbContext
    {
        public Bartending() : base("bartending")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bartender> Bartenders {get;set;}
        public DbSet<Cocktail_Order> Orders { get; set; }
        public DbSet<Drink_Menu> Menu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}