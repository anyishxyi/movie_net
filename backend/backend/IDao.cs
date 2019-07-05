using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    interface IDao<T>
    {
        Boolean create(T entity);
        Boolean delete(T entity);
        Boolean edit(T entity);
        List<T> findall();
        T findByName();
        T findById();
    }
}
