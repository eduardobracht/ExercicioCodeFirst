﻿using PL.Models;
using System;
using System.Collections.Generic;
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

        }

        public void Delete(int movieId)
        {
            var contexto = new MovieContext();
            var filme = contexto.Movies.Find(movieId);
            if (filme!=null) contexto.Movies.Remove(filme);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Movie GetMovieByID(int movieId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMovies()
        {
            throw new NotImplementedException();
        }

        public void Update(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
