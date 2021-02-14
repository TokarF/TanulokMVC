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
        TanuloDAO tanuloDAO = new TanuloDAO();

        public IActionResult OsztalyzatAdatok(int osztalyzatId, int tanuloId)
        {
            
            OsztalyzatModel osztalyzat = osztalyzatDAO.OsztalyzatIdAlapjan(osztalyzatId);

            // Ellenőrizni kell, hogy nem-e null az osztályzat, ha esetleg már törölve lett és úgy akar visszamenni valaki az osztályzat adataira, máskülönben a tanuló adatlapjára küldje vissza
            if (osztalyzat is not null)
            {
                return View(osztalyzat);
            }
            // Át kell irányítani a tanuló adatlapjára és jelezni, hogy nem található az osztályzat!
            else
            {
                TempData["Uzenet"] = "nincs_talalat";
                return RedirectToAction("Tanuloadatok", "Tanulo", new  { tanuloId = tanuloId });
            }


        }

        // Új osztályzat Form
        public IActionResult UjOsztalyzatForm(int tanuloId, int osztalyId)
        {
            // Át kell adni a Tanulo ID-t a formnak, hogy utána az alapján illeszthesse az adatbázisba
            ViewBag.TanuloId = tanuloId;
            // Szükség van az osztály ID-ra is mert, ha időközben törölve lett a tanuló, akkor vissza tudjon irányítani az osztályba
            ViewBag.OsztalyId = osztalyId;
            return View();
        }

        // Új osztályzat felvitele adatbázisba
        public IActionResult OsztalyzatFelvitel(OsztalyzatModel ujOsztalyzat, int osztalyId)
        {
            // Meg kell vizsgálni, hogy nem-e lett törölve a tanuló az adatbázisból időközben, csak akkor vihető fel az osztályzat az adatbázisba
            if (tanuloDAO.TanuloIdAlapjan(ujOsztalyzat.TanuloId) is not null)
            {
                try
                {
                    // Osztályzat felvitele AB-ba
                    osztalyzatDAO.OsztalyzatFelvitel(ujOsztalyzat);
                    TempData["Uzenet"] = "hozzaadas_siker";
                    // Visszatérés a tanuló adatlapjára
                    return RedirectToAction("TanuloAdatok", "Tanulo", new { tanuloId = ujOsztalyzat.TanuloId, osztalyId = osztalyId });      
                }
                catch (Exception)
                {

                    TempData["Uzenet"] = "osztalyzat_hozzaadas_hiba";
                    return RedirectToAction("TanuloAdatok", "Tanulo", new { tanuloIdid = ujOsztalyzat.TanuloId, osztalyId = osztalyId });
                }

            }
            // Ha törölve lett, akkor visszatérés az osztály adatlapra
            else
            {
                TempData["Uzenet"] = "osztalyzat_hozzaadas_hiba";
                return RedirectToAction("OsztalyAdatok", "Osztaly", new { tanuloIdid = ujOsztalyzat.TanuloId, osztalyId = osztalyId });
            }



        }

        // Osztályzat Módosítás form
        public IActionResult OsztalyzatModositasForm(int osztalyzatId)
        {
            OsztalyzatModel modositandoOsztalyzat = osztalyzatDAO.OsztalyzatIdAlapjan(osztalyzatId);

            // Át kell adni a formnak az osztály ID-t is, hogy kezelni lehessen, ha törölnék időközben a tanulót
            ViewBag.OsztalyId = tanuloDAO.TanuloIdAlapjan(modositandoOsztalyzat.TanuloId).OsztalyId;


            return View(modositandoOsztalyzat);
        }

        // Osztályzat módosítása az adatbázisban
        public IActionResult OsztalyzatModositas(OsztalyzatModel modositandoOsztalyzat, int osztalyId)
        {
            // Meg kell vizsgálni, hogy nem-e lett törölve a tanuló az adatbázisból időközben, csak akkor vihető fel az osztályzat az adatbázisba
            if (tanuloDAO.TanuloIdAlapjan(modositandoOsztalyzat.TanuloId) is not null)
            {
                try
                {
                    osztalyzatDAO.OsztalyzatModositas(modositandoOsztalyzat);
                    TempData["Uzenet"] = "osztalyzat_modositas_siker";

                    return RedirectToAction("OsztalyzatAdatok", "Osztalyzat", new { id = modositandoOsztalyzat.OsztalyzatId });

                }
                catch (Exception)
                {

                    TempData["Uzenet"] = "osztalyzat_modositas_hiba";
                    return RedirectToAction("OsztalyzatAdatok", "Osztalyzat", new { id = modositandoOsztalyzat.OsztalyzatId, });
                }

            }

            // Ha törölve lett akkor az osztályba irányítson vissza
            else
            {
                TempData["Uzenet"] = "osztalyzat_modositas_hiba";
                return RedirectToAction("TanuloAdatok", "Tanulo", new { tanuloIdid = modositandoOsztalyzat.TanuloId, osztalyId = osztalyId });
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
