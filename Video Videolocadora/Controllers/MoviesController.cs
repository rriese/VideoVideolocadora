using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Video_Videolocadora.Models;

namespace Video_Videolocadora.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/
        public ActionResult Random()
        {
            var movie = new Movie();
            movie.chingamentos.Add("Matheus");
            movie.chingamentos.Add("Lixo");
            return View(movie);
        }
	}
}