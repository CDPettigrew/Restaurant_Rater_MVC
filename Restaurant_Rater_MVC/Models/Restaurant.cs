using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Restaurant_Rater_MVC.Models
{
    public class Restaurant
    {
        public int RestuarantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Rating { get; set; }
    }

    public class RestuarantDbContext : DbContext 
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}