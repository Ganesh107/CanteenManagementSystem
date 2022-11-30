using CanteenManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CanteenManagement.Controllers
{
    public class CategoryController : Controller
    {
        CanteenContext CanteenContext = new CanteenContext();
        public ActionResult CategoryList()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllSouthIndianfood()
        {
            try
            {
                List<SouthIndian> southIndianfood = CanteenContext.southIndian.ToList();
                return View(southIndianfood);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult AddSouthFood()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSouthFood(SouthIndian fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.southIndian.Add(fooditem);
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllSouthIndianfood");
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
        public ActionResult EditSouthFood(int id)
        {
            try
            {
                SouthIndian fooditem = CanteenContext.southIndian.Find(id);
                return View(fooditem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditSouthFood(SouthIndian fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.Entry<SouthIndian>(fooditem).State = System.Data.Entity.EntityState.Modified;
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllSouthIndianfood");
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

        public ActionResult DeleteSouthFood(int id)
        {
            try
            {
                SouthIndian fooditem = CanteenContext.southIndian.Find(id);
                CanteenContext.southIndian.Remove(fooditem);
                CanteenContext.SaveChanges();
                return RedirectToAction("GetAllSouthIndianfood");
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult GetAllNorthIndianfood()
        {
            try
            {
                List<NorthIndian> northindianfood = CanteenContext.northIndian.ToList();
                return View(northindianfood);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult AddNorthfood()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddNorthfood(NorthIndian fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.northIndian.Add(fooditem);
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllNorthIndianfood");
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
        public ActionResult EditNorthfood(int id)
        {
            try
            {
                var fooditem = CanteenContext.northIndian.Find(id);
                return View(fooditem);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditNorthfood(NorthIndian fooditem)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CanteenContext.Entry<NorthIndian>(fooditem).State = System.Data.Entity.EntityState.Modified;
                    CanteenContext.SaveChanges();
                    return RedirectToAction("GetAllNorthIndianfood");
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

        public ActionResult DeleteNorthfood(int id)
        {
            try
            {
                NorthIndian fooditem = CanteenContext.northIndian.Find(id);
                CanteenContext.northIndian.Remove(fooditem);
                CanteenContext.SaveChanges();
                return RedirectToAction("GetAllNorthIndianfood");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}