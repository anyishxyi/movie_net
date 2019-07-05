using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    class UserDao : IDao<user>
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
            modelmovieContainer moviemodel = new modelmovieContainer();
            return moviemodel.userSet.ToList<user>();
        }

        public user findById(int id)
        {
            throw new NotImplementedException();
        }

        public user findByName(String name)
        {
            throw new NotImplementedException();
        }
    }
}
