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
                if(moviemodel.commentsSet1.Add(entity) != null)
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
                if (moviemodel.commentsSet1.Remove(entity) != null)
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
                comments result = (from res in moviemodel.commentsSet1 where res.Id == entity.Id select res).SingleOrDefault();
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
                return moviemodel.commentsSet1.ToList<comments>();
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
                return moviemodel.commentsSet1.First(item => item.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }

        public List<comments> findByMovie(movie myMovie)
        {
            modelmovieContainer moviemodel = new modelmovieContainer();
            return moviemodel.commentsSet1.Where(entity => entity.movie == myMovie).ToList();
        }
    }
}
