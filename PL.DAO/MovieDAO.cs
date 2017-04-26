using PL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.DAO
{
    public class MovieDAO : IMovieDAO
    {

        public void Add(Movie movie)
        {
            var contexto = new MovieContext();
            contexto.Movies.Add(movie);

            contexto.Database.Log = Console.Write;
            contexto.SaveChanges();
        }

        public void Delete(int movieId)
        {
            var contexto = new MovieContext();
            var filme = contexto.Movies.Find(movieId);
            if (filme != null) contexto.Movies.Remove(filme);

            contexto.Database.Log = Console.Write;
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            var contexto = new MovieContext();
            contexto.Dispose();
        }

        public IEnumerable<Genre> getGenres()
        {
            var contexto = new MovieContext();
            var listaGeneros = contexto.Genres.ToList();
            return listaGeneros;
        }

        public Movie GetMovieByID(int? movieId)
        {
            var contexto = new MovieContext();
            var filme = contexto.Movies.Find(movieId);
            return filme;
        }

        public IEnumerable<Movie> GetMovies()
        {
            var contexto = new MovieContext();
            var listaFilmes = contexto.Movies.ToList();
            return listaFilmes;
        }

        public void Update(Movie movie)
        {
            var contexto = new MovieContext();
            contexto.Entry(movie).State = EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}