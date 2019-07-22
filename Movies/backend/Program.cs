using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovieBackend m = new MovieBackend();

            // Console.WriteLine(m.addUser("soro", "diongo"));

            // Console.WriteLine(m.addMovie("ceci est un titre 1", "ceci est une categorie 1", "ceci est un synopsys 1", new DateTime(), "prod 1 prod 2 prod 3"));

            List<movie> listMovie = m.getAllMovies();

            foreach (movie myMovie in listMovie){
                Console.WriteLine(myMovie.title);
            }

            Console.ReadLine();
        }
    }
}
