using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIMS_Portal.Data
{
    public class Roles
    {
        public static string[] List => new[] { Admin, Customer };

        public const string Admin = "Admin";

        public const string Customer = "Customer";
    }
}
