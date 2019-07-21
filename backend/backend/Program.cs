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

            user us = userDao.findById(1);

            Console.WriteLine(us.password);

            us.password = "12345";

            userDao.edit(us);

            user us1 = userDao.findById(1);

            Console.WriteLine(us1.password);

            Console.ReadLine();
        }
    }
}
