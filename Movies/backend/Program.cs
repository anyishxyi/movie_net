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
            IMovieBackend m = MovieBackend.Instance;

            // Console.WriteLine(m.addUser("soro", "diongo"));

            // Console.WriteLine(m.addMovie("ceci est un titre", "ceci est une categorie", "ceci est un synopsys", "actor", new DateTime(), "prod 1 prod 2 prod 3"));

            List<movie> listMovie = m.getAllMovies();

            foreach (movie myMovie in listMovie){
                Console.WriteLine(myMovie.title);
            }

            Console.ReadLine();
        }
    }
}
