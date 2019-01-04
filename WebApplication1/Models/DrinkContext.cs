using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication1.Models
{
    public class DrinkContext : DbContext
    {
        public DrinkContext() : base("name = MyASPDrinksConnection")
        { }

        public DbSet<Drink> Drinks { get; set; }
    }
}