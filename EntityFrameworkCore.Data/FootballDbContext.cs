using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCore.Data
{
    public class FootballDbContext:DbContext
    {
        public DbSet <Team> Teams { get; set; }
        public DbSet <Coach> Coaches { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DataSource=(localdb)\\MSSQLLocalDB;Initial Catalog=Football;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    TeamId = 1,
                    Name = "Tivoli Gardens",
                    CreatedDate = DateTime.Now
                },
                new Team
                {
                    TeamId = 2,
                    Name = "Water House",
                    CreatedDate = DateTime.Now
                },
                new Team
                {
                    TeamId = 3,
                    Name = " Humle Lions",
                    CreatedDate = DateTime.Now
                }

                );
        }

    }
}
