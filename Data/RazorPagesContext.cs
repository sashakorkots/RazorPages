using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

    public class RazorPagesContext : DbContext
    {
        public RazorPagesContext (DbContextOptions<RazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPages.Models.Dish> Dish { get; set; }

        public DbSet<RazorPages.Models.Restrant> Restrant { get; set; }

        public DbSet<RazorPages.Models.Courier> Courier { get; set; }

        public DbSet<RazorPages.Models.DishsOfOrder> DishsOfOrder { get; set; }

        public DbSet<RazorPages.Models.Menu> Menu { get; set; }

        public DbSet<RazorPages.Models.Order> Order { get; set; }

        public DbSet<RazorPages.Models.Region> Region { get; set; }

        public DbSet<RazorPages.Models.Customer> Customer { get; set; }
    }
