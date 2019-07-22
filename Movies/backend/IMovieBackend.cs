using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    public interface IMovieBackend
    {
        List<movie> getAllMovies(); //Retourne la liste de tous les films
        bool addMovie(string title, string category, string synopsys, string actors, DateTime date, string productors); //ajoute un film dans la bdd
        bool removeMovie(int idMovie); //Supprime un film dans la bdd
        List<comments> getCommentsByIdMovie(int idMovie); // Retourne la liste de tous les commentaires qui existent sur un film demandé
        double getNoteByIdMovie(int idMovie); // Retourne la note générale d'un film demandé
        bool addComment(int idUser, int idMovie, string comment); // Permet à un utilisateur faire un commentaire de son film préféré
        bool addNote(int idUser, int idMovie, double note); // Permet à un utilisateur de donner une note à son film préféré
        bool addUser(string username, string password);
    }
}
