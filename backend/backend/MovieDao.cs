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
            throw new NotImplementedException();
        }

        public bool delete(movie entity)
        {
            throw new NotImplementedException();
        }

        public bool edit(movie entity)
        {
            throw new NotImplementedException();
        }

        public List<movie> findall()
        {
            throw new NotImplementedException();
        }

        public movie findById(int id)
        {
            throw new NotImplementedException();
        }

        public movie findByName(String name)
        {
            throw new NotImplementedException();
        }
    }
}
