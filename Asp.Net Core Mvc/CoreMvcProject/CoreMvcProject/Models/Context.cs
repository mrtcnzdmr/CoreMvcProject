using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcProject.Models
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MERT;database=UnitDB;integrated security=true;");
        }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
