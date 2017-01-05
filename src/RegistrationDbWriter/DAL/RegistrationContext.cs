using Microsoft.EntityFrameworkCore;
using RegistrationDbWriter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationDbWriter.DAL
{
    public class RegistrationContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=dc-snoop;Integrated Security=true;");
        }
    }
}
