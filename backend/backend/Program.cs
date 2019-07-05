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
            modelmovieContainer moviemodel = new modelmovieContainer();

            user user = new user();
            user.username = "admin";
            user.password = "admin";

            moviemodel.userSet.Add(user);

            moviemodel.SaveChanges();
        }
    }
}
