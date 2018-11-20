using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CryptoHelper;
using AIMS_Portal.Helpers;
using AIMS_Portal.Features;
using AIMS_Portal.Features.Users;

namespace AIMS_Portal.Data
{
    public static class DbInitializer
    {
        public static void SeedData(DbContext dataContext)
        {
            SeedUsers(dataContext);
        }

        private static void SeedUsers(DbContext dataContext)
        {
            var users = dataContext.Set<User>();

            if (users.Any())
            {
                AddAdminUser(dataContext);
                return;
            }

            AddAdminUser(dataContext);
            for (int i = 0; i < 20; i++)
            {
                users.Add(new User
                {
                    Email = $"email{i}@aimscompanies.com",
                    Password = CryptoHelpers.HashPassword($"password{i}"),
                    Company = $"Company{i}",
                    Role = Roles.Customer
                });
            }
        }

        private static void AddAdminUser(DbContext dataContext)
        {
            var users = dataContext.Set<User>();
            if (users.Any(x => x.Email == "admin@aimscompanies.com"))
            {
                return;
            }
            users.Add(new User
            {
                Email = $"admin@envoc.com",
                Password = CryptoHelpers.HashPassword("password"),
                Company = "AIMS Companies",
                Role = Roles.Admin
            });
            dataContext.SaveChanges();
        }
    }
}
