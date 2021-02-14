using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TanulokMVC.Models;
using TanulokMVC.Services;

namespace TanulokMVC.Controllers
{
    public class TanuloController : Controller
    {
        OsztalyDAO osztalyDAO = new OsztalyDAO();
        TanuloDAO tanuloDAO = new TanuloDAO();
        OsztalyzatDAO osztalyzatDAO = new OsztalyzatDAO();

        // ID alapján a tanuló lekérdezése adatbázisból
        public IActionResult TanuloAdatok(int tanuloId, int osztalyId)
        {
            // Tanuló lekérdezés
            TanuloModel tanulo = tanuloDAO.TanuloIdAlapjan(tanuloId);

            // Meg kell vizsgálni, hogy nem-e lett törölve időközben a tanuló az adatbázisból
            if (tanulo is not null)
            {
                // Tanulóhoz tartozó jegyek lekérdezése 
                tanulo.osztalyzatok = osztalyzatDAO.TanuloOsztalyzatok(tanuloId);
                return View(tanulo);
            }
            // Ha törölve lett a tanuló, akkor visszairányítás az osztályba
            else
            {
                return RedirectToAction("OsztalyAdatok", "Osztaly", new { osztalyId = osztalyId });
            }

        }

        public IActionResult UjTanuloForm(int osztalyId)
        {
            // Át kell adni az osztályok listáját a módosításhoz, hogy lehessen osztályt módosítani és tölteni az osztályok listáját
            ViewBag.OsztalyId = osztalyId;

            return View();
        }

        // Új tanuló felvitele, majd visszairányítás a megfelelő osztályba
        public IActionResult UjTanulo(TanuloModel ujTanulo)
        {
            try
            {
                tanuloDAO.Ujtanulo(ujTanulo);
                TempData["Uzenet"] = "hozzaadas_siker";
                return RedirectToAction("OsztalyAdatok", "Osztaly", new { osztalyId = ujTanulo.OsztalyId });
            }
            catch (Exception)
            {

                TempData["Uzenet"] = "hozzaadas_hiba";
                return RedirectToAction("OsztalyAdatok", "Osztaly", new { osztalyId = ujTanulo.OsztalyId });
            }

        }

        // Tanuló módosítás form, át kell adni a tanuló ID-t a formnak
        public IActionResult TanuloModositasForm(int tanuloId)
        {
            TanuloModel modositandoTanulo = tanuloDAO.TanuloIdAlapjan(tanuloId);

            // Át kell adni a formnak az osztályok listáját hogy lehessen módosítani az osztályt is
            ViewData["Osztalyok"] = osztalyDAO.OsszesOsztaly();

            return View(modositandoTanulo);
        }

        // Tanuló Módosítása - Visszairányítás a megfelelő osztályba
        public IActionResult TanuloModositas(TanuloModel modositandoTanulo)
        {
            try
            {
                TempData["Uzenet"] = "modositas_siker";
                tanuloDAO.TanuloModositas(modositandoTanulo);
                return RedirectToAction("OsztalyAdatok", "Osztaly", new { osztalyId = modositandoTanulo.OsztalyId });

            }
            catch (Exception)
            {

                TempData["Uzenet"] = "modositas_hiba";
                return RedirectToAction("OsztalyAdatok", "Osztaly", new { osztalyId = modositandoTanulo.OsztalyId });
            }

        }

        // Tanuló Törlése és az összes jegye - Visszairányítás az osztályba
        public IActionResult TanuloTorles(int osztalyId, int tanuloId)
        {
            try
            {
                tanuloDAO.TanuloTorles(tanuloId);
                TempData["Uzenet"] = "torles_siker";
                return RedirectToAction("OsztalyAdatok", "Osztaly", new { osztalyId = osztalyId });

            }
            catch (Exception)
            {

                TempData["Uzenet"] = "torles_hiba";
                return RedirectToAction("OsztalyAdatok", "Osztaly", new { osztalyId = osztalyId });
            }
        }
    }
}
