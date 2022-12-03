using CanteenManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CanteenManagement.Repository
{
    public class LoginRepo
    {
        CanteenContext canteenContext = new CanteenContext();   

        public AdminCred ValidateAdmin(AdminCred adminCred)
        {
			try
			{
                var user = canteenContext.adminCred.Where(p => p.Email.Equals(adminCred.Email) && p.Password.Equals(adminCred.Password)&& p.Status.Equals("Active")).FirstOrDefault();
                return user;
            }
			catch (Exception)
			{

				throw;
			}
        }
    }
}