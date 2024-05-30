using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class WorkshopController : Controller
    {
        Workshop workshop = new Workshop();
        private void getData(int id)
        {
            if (id == 1)
            {
                workshop.Id = 1;
                workshop.city = "Jakarta";
                workshop.location = "Jl. Gunung Sahari No 1";
                workshop.phone = "021-7890";
            }
            else if (id == 2)
            {
                workshop.Id = 2;
                workshop.city = "Bogor";
                workshop.location = "Jl. Pajajaran No 1";
                workshop.phone = "0251-1234";
            }
            else
            {
                workshop.Id = 3;
                workshop.city = "Depok";
                workshop.location = "Jl. Margonda No 1";
                workshop.phone = "021-4567";
            }
        }
        // GET: Workshop
        public ActionResult Index()
        {
            var workshops = new List<Workshop>();
            var workshop1 = new Workshop();
            workshop1.Id = 1;
            workshop1.city = "Jakarta";
            workshop1.location = "Jl. Gunung Sahari No 1";
            workshop1.phone = "021-7890";
            var workshop2 = new Workshop();
            workshop2.Id = 2;
            workshop2.city = "Bogor";
            workshop2.location = "Jl. Pajajaran No 1";
            workshop2.phone = "0251-1234";
            var workshop3 = new Workshop();
            workshop3.Id = 3;
            workshop3.city = "Depok";
            workshop3.location = "Jl. Margonda No 1";
            workshop3.phone = "021-4567";
            workshops.Add(workshop1);
            workshops.Add(workshop2);
            workshops.Add(workshop3);
            return View(workshops);
        }

        // GET: Workshop/Details/5
        public ActionResult Details(int id)
        {
            this.getData(id);
            return View(workshop);
        }

        // GET: Workshop/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Workshop/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Workshop/Edit/5
        public ActionResult Edit(int id)
        {
            this.getData(id);
            return View(workshop);
        }

        // POST: Workshop/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Workshop/Delete/5
        public ActionResult Delete(int id)
        {
            this.getData(id);
            return View(workshop);
        }

        // POST: Workshop/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
