using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Customizing_User_Data.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Customizing_User_DataUser class
    public class Customizing_User_DataUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
