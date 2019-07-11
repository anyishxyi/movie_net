using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    internal class MovieDao : IDao<movie>
    {
        public bool create(movie entity)
        {
            if (entity != null)
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                if (moviemodel.movieSet.Add(entity) != null)
                {
                    if(moviemodel.SaveChanges() > 0)
                        return true;
                }
            }
            return false;
        }

        public bool delete(movie entity)
        {
            if (entity != null)
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                if (moviemodel.movieSet.Remove(entity) != null)
                {
                    if(moviemodel.SaveChanges() > 0)
                        return true;
                }
            }
            return false;
        }

        public bool edit(movie entity)
        {
            if (entity != null)
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                movie result = (from res in moviemodel.movieSet where res.Id == entity.Id select res).SingleOrDefault();
                result.title = entity.title;
                result.category = entity.category;
                result.synopsys = entity.synopsys;
                result.actors = entity.actors;
                result.date = entity.date;
                result.productors = entity.productors;
                if(moviemodel.SaveChanges() > 0)
                    return true;
            }
            return false;
        }

        public List<movie> findall()
        {
            try
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                return moviemodel.movieSet.ToList<movie>();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }

        public movie findById(int id)
        {
            try
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                return moviemodel.movieSet.First(item => item.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }

        public movie findByName(String title)
        {
            try
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                return moviemodel.movieSet.First(item => item.title == title);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }
    }
}
