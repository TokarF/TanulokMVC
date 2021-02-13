﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TanulokMVC.Models;
using TanulokMVC.Services;

namespace TanulokMVC.Controllers
{
    public class OsztalyController : Controller
    {
        OsztalyDAO osztalyDAO = new OsztalyDAO();
        TanuloDAO tanuloDAO = new TanuloDAO();

        //
        public IActionResult Index()
        {
            return View(osztalyDAO.OsszesOsztaly());
        }

        // Osztályok tanulókkal lista nézet
        public IActionResult OsztalyokTanulokkalLista(string kereses = "")
        {
            List<OsztalyModel> osztalyok = osztalyDAO.OsszesOsztaly();
            if (kereses != null)
            {
                osztalyok.ForEach(osztaly => osztaly.diakok = tanuloDAO.OsztalyTanulok(osztaly.OsztalyId).Where(tanulo => tanulo.KeresztNev.ToLower().Contains(kereses.ToLower()) || tanulo.VezetekNev.ToLower().Contains(kereses.ToLower())).ToList());
            }
            else
            {
                osztalyok.ForEach(osztaly => osztaly.diakok = tanuloDAO.OsztalyTanulok(osztaly.OsztalyId));

            }

            return View(osztalyok);
        }



        public IActionResult OsztalyAdatok(int id)
        {
            OsztalyModel osztaly = osztalyDAO.OsztalyIdAlapjan(id);
            osztaly.diakok = tanuloDAO.OsztalyTanulok(id);
            return View(osztaly);
        }

        public IActionResult UjOsztalyForm()
        {
            return View();
        }

        public IActionResult OsztalyFelvitel(OsztalyModel ujOsztaly)
        {
            try
            {
                osztalyDAO.UjOsztaly(ujOsztaly);
                TempData["Uzenet"] = "hozzaadas_siker";
                return View("Index", osztalyDAO.OsszesOsztaly());
            }
            catch
            {
                TempData["Uzenet"] = "hozzaadas_hiba";
                return View("Index", osztalyDAO.OsszesOsztaly());
            }
        }

        public IActionResult OsztalyModositasForm(int id)
        {

                OsztalyModel modositandoOsztaly = osztalyDAO.OsztalyIdAlapjan(id);
                return View(modositandoOsztaly);


        }

        public IActionResult OsztalyModositas(OsztalyModel modositandoOsztaly)
        {
            try
            {
                osztalyDAO.OsztalyModositas(modositandoOsztaly);
                TempData["Uzenet"] = "modositas_siker";
                return View("Index", osztalyDAO.OsszesOsztaly());
            }
            catch (Exception)
            {

                TempData["Uzenet"] = "modositas_hiba";
                return View("Index", osztalyDAO.OsszesOsztaly());
            }
        }

    }
}
