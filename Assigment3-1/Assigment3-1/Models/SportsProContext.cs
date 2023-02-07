using System;
using Microsoft.EntityFrameworkCore;


namespace Assigment3_1.Models
{
    public class SportsProContext : DbContext
    {
        public SportsProContext(DbContextOptions<SportsProContext> options)
             : base(options)
        { }
        public DbSet<Technician> technicians { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductID = 1,
                ProductCode = "DRAFT10",
                ProductName = "Draft Manager 1.0",
                YearlyPrice = 4.99M,
                ReleaseDate = DateTime.Parse("2017-02-01")
            },
            new Product
            {
                ProductID = 2,
                ProductCode = "DRAFT20",
                ProductName = "Draft Manager 2.0",
                YearlyPrice = 5.99M,
                ReleaseDate = DateTime.Parse("2019-07-15 00:00:00.000")
            },
            new Product
            {
                ProductID = 3,
                ProductCode = "LEAG10",
                ProductName = "League Scheduler 1.0",
                YearlyPrice = 4.99M,
                ReleaseDate = DateTime.Parse("2016-05-01 00:00:00.000")
            },
            new Product
            {
                ProductID = 4,
                ProductCode = "LEAGD10",
                ProductName = "League Scheduler Deluxe 1.0",
                YearlyPrice = 7.99M,
                ReleaseDate = DateTime.Parse("2016-08-01 00:00:00.000")
            },
            new Product
            {
                ProductID = 5,
                ProductCode = "TEAM10",
                ProductName = "Team Manager 1.0",
                YearlyPrice = 4.99M,
                ReleaseDate = DateTime.Parse("2017-05-01 00:00:00.000")
            },
            new Product
            {
                ProductID = 6,
                ProductCode = "TRNY10",
                ProductName = "Tournament Master 1.0",
                YearlyPrice = 4.99M,
                ReleaseDate = DateTime.Parse("2015-12-01 00:00:00.000")
            },
            new Product
            {
                ProductID = 7,
                ProductCode = "TRNY20",
                ProductName = "Tournament Master 2.0",
                YearlyPrice = 5.99M,
                ReleaseDate = DateTime.Parse("2018-02-15 00:00:00.000")
            }
            );
               modelBuilder.Entity<Technician>().HasData(
               new Technician
            {
                TechnicianID = 11,
                Name = "Alison Diaz",
                Email = "alison@sportsprosoftware.com",
                Phone = "800-555-0443"
            },
            new Technician
            {
                TechnicianID = 12,
                Name = "Jason Lee",
                Email = "jason@sportsprosoftware.com",
                Phone = "800-555-0444"
            },
            new Technician
            {
                TechnicianID = 13,
                Name = "Andrew Wilson",
                Email = "awilson@sportsprosoftware.com",
                Phone = "800-555-0449"
            },
            new Technician
            {
                TechnicianID = 14,
                Name = "Gunter Wendt",
                Email = "gunter@sportsprosoftware.com",
                Phone = "800-555-0400"
            },
            new Technician
            {
                TechnicianID = 15,
                Name = "Gina Fiori",
                Email = "gfiori@sportsprosoftware.com",
                Phone = "800-555-0459"

            }
            );
        }

    }
}
