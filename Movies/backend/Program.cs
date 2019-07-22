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

            Console.WriteLine(m.addUser("admin1", "admin2"));

            Console.ReadLine();
        }
    }
}
