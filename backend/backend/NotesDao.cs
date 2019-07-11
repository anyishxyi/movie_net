using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    internal class NotesDao : IDao<notes>
    {
        public bool create(notes entity)
        {
            if (entity != null)
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                if (moviemodel.notesSet.Add(entity) != null)
                {
                    moviemodel.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool delete(notes entity)
        {
            if (entity != null)
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                if (moviemodel.notesSet.Remove(entity) != null)
                {
                    moviemodel.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool edit(notes entity)
        {
            if (entity != null)
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                notes result = (from res in moviemodel.notesSet where res.Id == entity.Id select res).SingleOrDefault();
                result.note = entity.note;
                result.user = entity.user;
                result.movie = entity.movie;
                moviemodel.SaveChanges();
                return true;
            }
            return false;
        }

        public List<notes> findall()
        {
            try
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                return moviemodel.notesSet.ToList<notes>();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }

        public notes findById(int id)
        {
            try
            {
                modelmovieContainer moviemodel = new modelmovieContainer();
                return moviemodel.notesSet.First(item => item.Id == id);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return null;
        }

        public notes findByName(String name)
        {
            throw new NotImplementedException();
        }
    }
}
