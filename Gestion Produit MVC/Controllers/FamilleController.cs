

using Gestion_Produit_MVC.Models;
using Gestion_Produit_MVC.Models.repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestion_Produit_MVC.Controllers
{
    public class FamilleController : Controller
    {
        //injection du service FamilyRepository
        public IRepository<Famille> Repository { get; set; }

        public FamilleController(IRepository<Famille> repository)
        {
            Repository = repository;
        }

        public IActionResult Index()
        {
            var familles = Repository.Lister();
            return View(familles);
        }

        public IActionResult Details(int id)
        {
            var famille = Repository.ListerSelonId(id);
            return View(famille);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Famille famille)
        {
            try
            {
                Repository.Ajouter(famille);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception)
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            var famille = Repository.ListerSelonId(id);
            return View(famille);
        }

        [HttpPost]
        public ActionResult Edit(int id, Famille famille)
        {
            try
            {
                Repository.Modifier(id,famille);
                return RedirectToAction(nameof(Index));
                
            }
            catch (Exception)
            {

                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var famille = Repository.ListerSelonId(id);
            return View(famille);
        }

        [HttpPost]

        public ActionResult Delete(int id, Famille famille)
        {
            try
            {
                Repository.Suprimer(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception)
            {

                return View();
            }
        }
    }
}
