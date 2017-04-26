using PL.DAO;
using PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstApp
{
    class Program
    {
        private static object listaFilmes;

        static void Main(string[] args)
        {
            #region CRUD

            // ADIÇÃO DE ATORES

            //using (var contexto = new MovieContext())
            //{
            //    var listaFilmes = contexto.Movies.ToList();

            //    // insert
            //    contexto.Actors.Add(new Actor()
            //    {
            //        Age = 43,
            //        Name = "Christian Bale"
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    var listaFilmes = contexto.Movies.ToList();

            //    // insert
            //    contexto.Actors.Add(new Actor()
            //    {
            //        Age = 59,
            //        Name = "Gary Oldman"
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    var listaFilmes = contexto.Movies.ToList();

            //    // insert
            //    contexto.Actors.Add(new Actor()
            //    {
            //        Age = 36,
            //        Name = "Elijah Wood"
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    var listaFilmes = contexto.Movies.ToList();

            //    // insert
            //    contexto.Actors.Add(new Actor()
            //    {
            //        Age = 40,
            //        Name = "Orlando Bloom"
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    var listaFilmes = contexto.Movies.ToList();

            //    // insert
            //    contexto.Actors.Add(new Actor()
            //    {
            //        Age = 52,
            //        Name = "Keanu Reeves"
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    var listaFilmes = contexto.Movies.ToList();

            //    // insert
            //    contexto.Actors.Add(new Actor()
            //    {
            //        Age = 55,
            //        Name = "Laurence Fishburne"
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    var listaFilmes = contexto.Movies.ToList();

            //    // insert
            //    contexto.Actors.Add(new Actor()
            //    {
            //        Age = 58,
            //        Name = "Tim Robbins"
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    var listaFilmes = contexto.Movies.ToList();

            //    // insert
            //    contexto.Actors.Add(new Actor()
            //    {
            //        Age = 79,
            //        Name = "Morgan Freeman"
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}


            // INSERTS ACTOR_MOVIES

            //using (var contexto = new MovieContext())
            //{
            //    // insert
            //    contexto.ActorMovies.Add(new ActorMovie()
            //    {
            //        Role = "Bruce Wayne",
            //        ActorID = 5,
            //        MovieID = 6
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    // insert
            //    contexto.ActorMovies.Add(new ActorMovie()
            //    {
            //        Role = "Jim Gordon",
            //        ActorID = 6,
            //        MovieID = 6
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    // insert
            //    contexto.ActorMovies.Add(new ActorMovie()
            //    {
            //        Role = "Frodo Baggins",
            //        ActorID = 7,
            //        MovieID = 7
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    // insert
            //    contexto.ActorMovies.Add(new ActorMovie()
            //    {
            //        Role = "Legolas",
            //        ActorID = 8,
            //        MovieID = 7
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    // insert
            //    contexto.ActorMovies.Add(new ActorMovie()
            //    {
            //        Role = "Neo",
            //        ActorID = 9,
            //        MovieID = 9
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    // insert
            //    contexto.ActorMovies.Add(new ActorMovie()
            //    {
            //        Role = "Morpheus",
            //        ActorID = 10,
            //        MovieID = 9
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    // insert
            //    contexto.ActorMovies.Add(new ActorMovie()
            //    {
            //        Role = "Andy Dufresne",
            //        ActorID = 11,
            //        MovieID = 2
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}

            //using (var contexto = new MovieContext())
            //{
            //    // insert
            //    contexto.ActorMovies.Add(new ActorMovie()
            //    {
            //        Role = "Ellis Boyd Redding",
            //        ActorID = 12,
            //        MovieID = 2
            //    });
            //    contexto.Database.Log = Console.Write;
            //    contexto.SaveChanges();
            //}



            #endregion

            #region Consultas

            MovieContext context = new MovieContext();

            //MovieDAO daoContexto = new MovieDAO();
            //Movie movie = daoContexto.GetMovieByID(2);
            //Console.WriteLine(movie.Title);

            //a) Listar o elenco de um determinado filme

            // Console.WriteLine("14a: Elenco do filme Batman: ");
            // context.Database.Log = Console.Write;
            // var query5 = (from f in context.Movies
            ////                                .Include("ActorMovie").Include("Actor")
            //              where f.Title == "The Dark Knight"
            //              select f).First();

            // foreach (var filme in query5.ActorMovie)
            // {
            //     Console.WriteLine("Atores do filme {0}\t", filme.Actor.Name);

            // }

            Console.WriteLine("14a: Elenco do filme Batman: ");
            //context.Database.Log = Console.Write;
            var query5 = (from f in context.ActorMovies
                                 .Include("Movie").Include("Actor")
                          where f.Movie.Title == "The Dark Knight"
                          select f);

            foreach (var am in query5)
            {
                Console.WriteLine("Atores do filme {0}\t{1}", am.Role, am.Actor.Name);
            }



            //var query5 = from f in context.Movies
            //             where f.Title == "The Dark Knight"
            //             select f;

            //foreach (var filme in query5)
            //{

            //}



            //var query4 = (from genero in context.Genres
            //                                   .Include("Movies")
            //              where genero.Name == "Action"
            //              select genero).First();

            //foreach (var filme in query4.Movies)
            //{
            //    Console.WriteLine("\t" + filme.Title);
            //}





            ////todos os filmes do genero "Action"
            //String filme = "The Dark Knight";
            //Console.WriteLine("\nAtores de " + filme);
            ////context.Database.Log = Console.Write;
            //var query4 = (from filmes in context.Movies
            //                                   .Include("ActorMovies")
            //              where filmes.Title == filme
            //              select filmes).First();

            //foreach (var movie in query4.ActorMovie)
            //{
            //    Console.WriteLine("\t" + movie.Role);

            //}



            ////projeção sobre o título e dada de lançamento dos
            ////filmes do diretor “Quentin Tarantino” 
            //var query5 = from f in context.Actors
            //             where f.Name == "Christian Bale"
            //             select new { f.Name, f.Age};

            //foreach (var actor in query5)
            //{
            //    Console.WriteLine("{0}\t {1}", actor.Name, actor.Age);
            //}





            //b) Listar todos os atores que já desempenharam um determinado personagem
            //(por exemplo, quem foram todos os “agentes 007”?)



            //c) Informar qual o ator desempenhou mais vezes um determinado personagem
            //(qual o ator que realizou mais filmes como o “agente 007”)



            //d) Outras consultas que o grupo julgar interessante.



            //15.Crie uma nova migração para realizar a alteração no banco de dados e insira
            //alguns dados que permitam testar o modelo proposto e as consultas acima.




            #endregion

            Console.ReadKey();
        }
    }
}