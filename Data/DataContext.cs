using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIMS_Portal.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            
        }

        public DbSet<Features.User> User { get; set; }

        public DbSet<Features.Deliverable.Job> Job { get; set; }

        public DbSet<Features.Companies.Company> Company { get; set; }

    }
}
