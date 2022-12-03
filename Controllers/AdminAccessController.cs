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
                    Session["Email"] = adminCred.Email;
                    return RedirectToAction("CategoryList","Category");
                }
                else
                {

                    TempData["invalid"] = "Invalid Details";
                    return View();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult GetAllAdmin()
        {
            try
            {
                List<AdminCred> adminCreds = canteenContext.adminCred.ToList();
                return View(adminCreds);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult AddAdmin() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin( AdminCred adminCred)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    adminCred.Status = "Pending";
                    canteenContext.adminCred.Add(adminCred);

                    canteenContext.SaveChanges();
                    //return View("GetAllAdmin"); 
                    return RedirectToAction("GetAllAdmin");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            try
            {
                AdminCred adminCred = canteenContext.adminCred.Find(id);
                //return RedirectToAction("adminCred");
                return View(adminCred);
            }

            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public ActionResult EditAdmin(AdminCred adminCred)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    canteenContext.Entry<AdminCred>(adminCred).State = System.Data.Entity.EntityState.Modified;
                    canteenContext.SaveChanges();
                    return RedirectToAction("GetAllAdmin");
                }
                else
                {
                    return View();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        
        public ActionResult DeleteAdmin(int id)
        {
            try
            {
                AdminCred adminCred = canteenContext.adminCred.Find(id);
                canteenContext.adminCred.Remove(adminCred);
                canteenContext.SaveChanges();
                return RedirectToAction("GetAllAdmin");
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}