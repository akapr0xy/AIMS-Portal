using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIMS_Portal.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> User { get; set; }


    }
}
