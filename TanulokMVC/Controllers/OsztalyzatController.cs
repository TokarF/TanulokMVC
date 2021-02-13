using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TanulokMVC.Models;
using TanulokMVC.Services;

namespace TanulokMVC.Controllers
{
    public class OsztalyzatController : Controller
    {
        OsztalyzatDAO osztalyzatDAO = new OsztalyzatDAO();

        // Adott osztályzat részletes adatai
        public IActionResult OsztalyzatAdatok(int id)
        {
            OsztalyzatModel osztalyzat = osztalyzatDAO.OsztalyzatIdAlapjan(id);
            return View(osztalyzat);
        }

        // Új osztályzat Form
        public IActionResult UjOsztalyzatForm(int tanuloId)
        {
            // Át kell adni a Tanulo ID-t a formnak, hogy utána az alapján illeszthesse az adatbázisba
            ViewBag.TanuloId = tanuloId;
            return View();
        }

        // Új osztályzat felvitele adatbázisba
        public IActionResult OsztalyzatFelvitel(OsztalyzatModel ujOsztalyzat)
        {
            try
            {
                // Osztályzat felvitele AB-ba
                osztalyzatDAO.OsztalyzatFelvitel(ujOsztalyzat);
                TempData["Uzenet"] = "hozzaadas_siker";
                // Visszatérés a tanuló adatlapjára
                return RedirectToAction("TanuloAdatok", "Tanulo", new { tanuloId = ujOsztalyzat.TanuloId });      


            }
            catch (Exception)
            {

                TempData["Uzenet"] = "hozzaadas_hiba";
                return RedirectToAction("TanuloAdatok", "Tanulo", new { id = ujOsztalyzat.TanuloId });      
            }

        }

        // Osztályzat Módosítás form
        public IActionResult OsztalyzatModositasForm(int osztalyzatId)
        {
            OsztalyzatModel modositandoOsztalyzat = osztalyzatDAO.OsztalyzatIdAlapjan(osztalyzatId);
            return View(modositandoOsztalyzat);
        }

        // Osztályzat módosítása az adatbázisban
        public IActionResult OsztalyzatModositas(OsztalyzatModel modositandoOsztalyzat)
        {
            try
            {
                osztalyzatDAO.OsztalyzatModositas(modositandoOsztalyzat);
                TempData["Uzenet"] = "modositas_siker";
                return RedirectToAction("OsztalyzatAdatok", "Osztalyzat", new { id = modositandoOsztalyzat.OsztalyzatId });
            }
            catch (Exception)
            {

                TempData["Uzenet"] = "modositas_hiba";
                return RedirectToAction("OsztalyzatAdatok", "Osztalyzat", new { id = modositandoOsztalyzat.OsztalyzatId });
            }

        }

        // Osztályzat törlése az adatbázisból
        public IActionResult OsztalyzatTorles(int osztalyzatId, int tanuloId)
        {
            try
            {
                osztalyzatDAO.OsztalyzatTorles(osztalyzatId);
                TempData["Uzenet"] = "torles_siker";
                return RedirectToAction("TanuloAdatok", "Tanulo", new { tanuloId = tanuloId });
            }
            catch (Exception)
            {
                TempData["Uzenet"] = "torles_hiba";
                return RedirectToAction("TanuloAdatok", "Tanulo", new { tanuloId = tanuloId });
            }


        }

        
    }
}
