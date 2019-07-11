using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    internal class CommentsDao : IDao<comments>
    {
        public bool create(comments entity)
        {
            if (entity != null)
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                if (moviemodel.commentsSet.Add(entity) != null)
                {
                    if(moviemodel.SaveChanges() > 0)
                        return true;
                }
            }
            return false;
        }

        public bool delete(comments entity)
        {
            if (entity != null)
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                if (moviemodel.commentsSet.Remove(entity) != null)
                {
                    if (moviemodel.SaveChanges() > 0)
                        return true;
                }
            }
            return false;
        }

        public bool edit(comments entity)
        {
            if (entity != null)
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                comments result = (from res in moviemodel.commentsSet where res.Id == entity.Id select res).SingleOrDefault();
                result.comment = entity.comment;
                result.user = entity.user;
                result.movie = entity.movie;
                if (moviemodel.SaveChanges() > 0)
                    return true;
            }
            return false;
        }

        public List<comments> findall()
        {
            try
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                return moviemodel.commentsSet.ToList<comments>();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }

        public comments findById(int id)
        {
            try
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                return moviemodel.commentsSet.First(item => item.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }

        public comments findByName(String name)
        {
            throw new NotImplementedException();
        }
    }
}
