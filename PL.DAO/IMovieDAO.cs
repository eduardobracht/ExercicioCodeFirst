using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Models;

namespace PL.DAO
{
    public interface IMovieDAO : IDisposable
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovieByID(int? movieId);
        void Add(Movie movie);
        void Delete(int movieId);
        void Update(Movie movie);

        IEnumerable<Genre> getGenres();
    }
}
