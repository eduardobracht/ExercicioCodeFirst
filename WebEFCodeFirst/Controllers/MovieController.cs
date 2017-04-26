using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PL.Models;
using PL.DAO;

namespace WebEFCodeFirst.Controllers
{
    public class MovieController : Controller
    {
        private IMovieDAO db = new MovieDAO();

        // GET: Movie
        public ActionResult Index()
        {
            //var movies = db.Movies.Include(m => m.Genre);
            var movies = db.GetMovies();
            return View(movies.ToList());
        }

        // GET: Movie/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Movie movie = db.Movies.Find(id);
            Movie movie = db.GetMovieByID(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            ViewBag.GenreID = new SelectList(db.getGenres(), "GenreID", "Name");
            return View();
        }

        // POST: Movie/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieID,Title,Director,ReleaseDate,Gross,Rating,GenreID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                //db.Movies.Add(movie);
                db.Add(movie);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenreID = new SelectList(db.getGenres(), "GenreID", "Name", movie.GenreID);
            return View(movie);
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.GetMovieByID(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenreID = new SelectList(db.getGenres(), "GenreID", "Name", movie.GenreID);
            return View(movie);
        }

        // POST: Movie/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieID,Title,Director,ReleaseDate,Gross,Rating,GenreID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(movie).State = EntityState.Modified;
                db.Update(movie);
                return RedirectToAction("Index");
            }
            //ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Name", movie.GenreID);
            ViewBag.GenreID = new SelectList(db.getGenres(), "GenreID", "Name", movie.GenreID);
            return View(movie);
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.GetMovieByID(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Movie movie = db.GetMovieByID(id);
            db.Delete(id);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        public ActionResult Catalogo(string titulo = "naoEncontrado")
        {
            string filePath = Server.MapPath("~/Content/Catalogo/") +
           titulo.ToLower() + ".pdf";
            if (System.IO.File.Exists(filePath))
                return new FilePathResult(filePath, "application/pdf");
            else
                return HttpNotFound();
        }

        public JsonResult Filmes()
        {
            // atenção: este código é apenas um exemplo;
            // ver possíveis vulnerabilidades em:
            // http://msdn.microsoft.com/query/dev11.query?appId=Dev11IDEF1&l=ENUS&k=k(System.Web.Mvc.JsonRequestBehavior);k(TargetFrameworkMoniker-.NETFramework,Version % 3Dv4.5); k(DevLang - csharp) & rd = true
            // http://haacked.com/archive/2008/11/20/anatomy-of-a-subtle-json-vulnerability.aspx
            // http://msdn.microsoft.com/en-us/library/hh404095.aspx
            var model = from movie in db.GetMovies()
                        select new
                        {
                            Titulo = movie.Title,
                            Diretor = movie.Director,
                            Ano = movie.ReleaseDate.Year,
                            Genero = movie.Genre.Name
                        };
            return Json(model.OrderBy(m => m.Ano), JsonRequestBehavior.AllowGet);
        }


    }
}

