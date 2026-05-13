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

    }
}
