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
            UserDao userDao = new UserDao();

            Console.WriteLine(userDao.findById(9).username);

            Console.ReadLine();
        }
    }
}
