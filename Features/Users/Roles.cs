using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIMS_Portal.Features.Users
{
    public class Roles
    {
        public static string[] List => new[] { Admin, Customer };

        public const string Admin = "Admin";

        public const string Customer = "Customer";
    }
}
