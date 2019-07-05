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
            user us = new user();
            us.username = "superman";
            us.password = "superman";
            userDao.create(us);

            foreach (user u in userDao.findall()) {
                Console.WriteLine(u.username);
            }

            Console.ReadLine();
        }
    }
}
