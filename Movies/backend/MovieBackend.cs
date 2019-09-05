using System;
using System.Collections.Generic;

namespace backend
{
    public sealed class MovieBackend : IMovieBackend
    {
        private static MovieBackend instance = null;
        private static readonly object padlock = new object();

        private movie myMovie;
        private comments myComment;
        private user myUser;
        private notes myNote;

        private CommentsDao commentsDao;
        private MovieDao movieDao;
        private NotesDao notesDao;
        private UserDao userDao;

        private MovieBackend()
        {
            myMovie = new movie();
            myComment = new comments();
            myUser = new user();
            myNote = new notes();

            commentsDao = new CommentsDao();
            movieDao = new MovieDao();
            notesDao = new NotesDao();
            userDao = new UserDao();
        }

        public static MovieBackend Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new MovieBackend();
                    }
                    return instance;
                }
            }
        }

        public bool addComment(int idUser, int idMovie, string comment)
        {
            if(comment != null)
            {
                myComment.comment = comment;
                myComment.movie = movieDao.findById(idMovie);
                myComment.user = userDao.findById(idUser);

                if(myComment.movie != null && myComment.user != null)
                {
                    return commentsDao.create(myComment);
                }
            }
            return false;
        }

        public bool addMovie(string title, string category, string synopsys, string actors, DateTime date, string productors)
        {
            if(title != "" && category != "" && synopsys != "" && date != null && productors != "")
            {
                myMovie.title = title;
                myMovie.category = category;
                myMovie.synopsys = synopsys;
                myMovie.date = date.ToString();
                myMovie.productors = productors;
                myMovie.actors = actors;

                return movieDao.create(myMovie);
            }

            return false;
        }

        public bool addNote(int idUser, int idMovie, double note)
        {
            if(note >= 0 && note <= 5)
            {
                myNote.note = note;
                myNote.user = userDao.findById(idUser);
                myNote.movie = movieDao.findById(idMovie);
                if (myNote.user != null && myNote.movie != null)
                {
                    return notesDao.create(myNote);
                }
            }
            return false;
        }

        public List<comments> getCommentsByIdMovie(int idMovie)
        {
            myMovie = movieDao.findById(idMovie);
            if(myMovie != null)
            {
                return commentsDao.findByMovie(myMovie);
            }
            return null;
        }

        public double getNoteByIdMovie(int idMovie)
        {
            myMovie = movieDao.findById(idMovie);
            if (myMovie != null)
            {
                List<notes> allNotes = notesDao.findByMovie(myMovie);
                if(allNotes != null)
                {
                    double values = 0;
                    int count = 0;
                    foreach (notes n in allNotes)
                    {
                        values += n.note;
                        count += 1;
                    }
                    return values / count;
                }
            }
            return -1;
        }

        public List<movie> getAllMovies()
        {
            return movieDao.findall();
        }

        public bool removeMovie(int idMovie)
        {
            return movieDao.delete(movieDao.findById(idMovie));
        }

        public bool addUser(string username, string password)
        {
            if(username != "" && password != "")
            {
                myUser.username = username;
                myUser.password = password;

                return userDao.create(myUser);
            }
            return false;
        }
    }
}
