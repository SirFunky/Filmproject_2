using Filmproject_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filmproject_2.Controllers
{
    public class FilmController : Controller
    {
        // GET: Film
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VisaFilm(int id)
        {
            Film nyFilm = new Film();
            if (id == 1)
            {
                nyFilm.Titel = "Lejonkungen";
                nyFilm.Åldersgräns = 7;
            }
            else if (id == 2)
            {
                nyFilm.Titel = "Toy Story 4";
                nyFilm.Åldersgräns = 3;
            }
            return View(nyFilm);
        }
    }
}