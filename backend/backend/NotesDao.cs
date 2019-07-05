using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    class NotesDao : IDao<notes>
    {
        public bool create(notes entity)
        {
            throw new NotImplementedException();
        }

        public bool delete(notes entity)
        {
            throw new NotImplementedException();
        }

        public bool edit(notes entity)
        {
            throw new NotImplementedException();
        }

        public List<notes> findall()
        {
            throw new NotImplementedException();
        }

        public notes findById(int id)
        {
            throw new NotImplementedException();
        }

        public notes findByName(String name)
        {
            throw new NotImplementedException();
        }
    }
}
