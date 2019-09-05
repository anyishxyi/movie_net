using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    internal interface IDao<T>
    {
        Boolean create(T entity);
        Boolean delete(T entity);
        Boolean edit(T entity);
        List<T> findall();
        T findById(int id);
        List<T> findByMovie(movie myMovie);// spécialement utilisé pour l'instant dans la CommentDAO pour retourner tous les commentaires sur un film donné
    }
}
