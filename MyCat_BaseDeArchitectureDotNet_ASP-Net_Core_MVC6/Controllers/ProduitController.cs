using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCat_BaseDeArchitectureDotNet_ASP_Net_Core_MVC6.Service;

namespace MyCat_BaseDeArchitectureDotNet_ASP_Net_Core_MVC6.Controllers
{ 
    public class ProduitController : Controller
    {
        public IProduitService metier { get; set; }


        public ProduitController(IProduitService metier)
        {
            this.metier = metier;
        }


        // GET: /<controller>/
        public ActionResult Index()
        {
            IEnumerable<Produit> prods = metier.FindAll();

          
            return View("Produits", prods);
        }


        public ActionResult Chercher(string motCle)
        {
            if (motCle == null)
            {
                ModelState.AddModelError("motCle", "il faut saisir un mot clé");
            }

            if (ModelState.IsValid) {

                IEnumerable<Produit> prodsParMC = metier.ProduitParMC(motCle);

                 ViewBag.motCle = motCle;
                return View("Produits", prodsParMC);
            } else {
                return View("Produits", metier.FindAll());
            }
        }


        public ActionResult ProduitForm()
        {

            Produit produit = new Produit();

            return View("ProduitForm", produit);
        }

 
        [HttpPost]
        public ActionResult SaveProduit(Produit produit)
        {

            if (ModelState.IsValid)
            {
                metier.Save(produit);
                return RedirectToAction("Index"); 
            }
            else
            {
                return View("ProduitForm");
            } 
            
        }


        [HttpGet]  //optionnelle
        public ActionResult Delete(int ID)
        { 
                metier.Delete(ID);
                return RedirectToAction("Index"); 
        }

         
        public ActionResult Editer(int ID)
        {
                 Produit p= metier.GetOne(ID);
                return View("ProduitFormEdit",p); 
        }
        
        public ActionResult Update(Produit p)
        {
            if (ModelState.IsValid)
            {
                metier.Update(p);
                return RedirectToAction("Index");
            }
            else
            {
                return View("ProduitFormEdit");
            } 
        }

    }
}