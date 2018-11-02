using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CryptoHelper;
using AIMS_Portal.Helpers;

namespace AIMS_Portal.Data
{
    //public static class DbInitializer
    //{
    //    public static void SeedData(DbContext dataContext)
    //    {
    //        SeedUsers(dataContext);
    //    }

    //    private static void SeedUsers(DbContext dataContext)
    //    {
    //        var users = dataContext.Set<User>();

    //        if(users.Any())
    //        {
    //            AddAdminUser(dataContext);
    //            return;
    //        }
    //        AddAdminUser(dataContext);
    //        for(int i = 0; i < 20; i++)
    //        {
    //            users.Add(new User
    //            {
    //                Email = $"email{i}@aimscompanies.com",
    //                Password = CryptoHelpers.HashPassword($"password{i}"),
    //                Company = $"Company{i}",
    //                Role = Roles.Customer
    //            });
    //        }
    //    }
    //}
}
