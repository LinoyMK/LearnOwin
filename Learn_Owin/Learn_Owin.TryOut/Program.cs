using Learn_Owin.DataAccess.ElasticSearch.CRUD.Read;
using Learn_Owin.DataAccess.ElasticSearch.CRUD.Write;
using Learn_Owin.DataAccess.ElasticSearch.Model;
using Learn_Owin.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Learn_Owin.TryOut
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               //  InsertSample();
                new ElasticRead().Search("Hitlor");


                //TestException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }


        private static string TestException()
        {
            throw new NotImplementedCustomException();
        }

        private static void InsertSample()
        {
            IEnumerable<Actor> actors = Enumerable.Range(0, 10).Select(i => new Actor() { Industry = "industry " + i, Name = "actor " + i });

            foreach (Actor actor in actors)
            {
                new ElasticWrite().IndexDocument(actor);
            }


            IEnumerable<Movie> movies = Enumerable.Range(0, 10).Select(i => new Movie() { Year = 2000 + i, Name = "movie " + i });

            foreach (Movie movie in movies)
            {
                new ElasticWrite().IndexDocument(movie);
            }
        }

    }
}
