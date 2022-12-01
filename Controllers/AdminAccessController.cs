using CanteenManagement.Models;
using CanteenManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CanteenManagement.Controllers
{
    public class AdminAccessController : Controller
    {
        CanteenContext canteenContext = new CanteenContext();
        LoginRepo loginRepo = new LoginRepo();
        // GET: AdminAccess
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(AdminCred adminCred)
        {
            try
            {
                var details = loginRepo.ValidateAdmin(adminCred);
                if (details != null)
                {
                    return RedirectToAction("CategoryList","Category");
                }
                else
                {
                    TempData["Invalid"] = "Invalid Details";
                    return View();
                }


         

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}