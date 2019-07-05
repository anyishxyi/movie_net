using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    internal class UserDao : IDao<user>
    {
        public bool create(user entity)
        {
            if(entity != null)
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                if (moviemodel.userSet.Add(entity) != null)
                {
                    moviemodel.SaveChanges();
                    return true;
                }                
            }
            return false;
        }

        public bool delete(user entity)
        {
            if (entity != null)
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                if (moviemodel.userSet.Remove(entity) != null)
                {
                    moviemodel.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool edit(user entity)
        {
            throw new NotImplementedException();
        }

        public List<user> findall()
        {
            try
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                return moviemodel.userSet.ToList<user>();
            } catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }

        public user findById(int id)
        {
            try
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                return moviemodel.userSet.First(item => item.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }

        public user findByName(String name)
        {
            try
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                return moviemodel.userSet.First(item => item.username == name);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }
    }
}
