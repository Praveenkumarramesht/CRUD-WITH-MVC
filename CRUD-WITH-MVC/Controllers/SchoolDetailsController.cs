using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;

namespace CRUD_WITH_MVC.Controllers
{
    public class SchoolDetailsController : Controller
    {
        public readonly ISchoolDetailsRepository obj;
        public SchoolDetailsController()
        {
            obj = new SchoolDetailsRepository();
        }
        // GET: SchoolDetailsController
        public ActionResult Index()
        {
            var result = obj.ReadSP();
            return View("List",result);
        }

        // GET: SchoolDetailsController/Details/5
        public ActionResult Details(int id)
        {
            var det = obj.FindSchoolDetailsByIdSP(id);
            return View("Details",det);
        }

        // GET: SchoolDetailsController/Create
        public ActionResult Create()
        {
            return View("Crete",new SchoolDetailss());
        }

        // POST: SchoolDetailsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SchoolDetailss value)
        {
            try
            {
                obj.InsertSP(value);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SchoolDetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            var cha = obj.FindSchoolDetailsByIdSP(id);
            return View("Edit",cha);
        }

        // POST: SchoolDetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SchoolDetailss values)
        {
            try
            {
                obj.UpdateSchoolDetailsByIdSP(id, values);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SchoolDetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SchoolDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
