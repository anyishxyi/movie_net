
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using System.Windows.Forms;

namespace Movies
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand MyCommandConnect { get; }
        public RelayCommand MyCommandAddFilm { get; }
        public RelayCommand MyCommandFind { get; }
        public RelayCommand MyCommandDescription { get; }
        public RelayCommand MyCommandDelete { get; }
        public RelayCommand MyCommandUpdate { get; }


        private string _name;


        // ferme les pages pour la transition façon boite de dialogue... avant de trouver une autre solution
        public Action CloseAction { get; set; }


        // pour avoir italic
        public FontStyle FontStyleTreeItem { get; set; }




        public MainViewModel()
        {
            FontStyleTreeItem = FontStyles.Italic;
            Name = "Veuillez vous identifier";
            MyCommandConnect = new RelayCommand(MyCommandExecute, MyCommandCanExecute);
            MyCommandFind = new RelayCommand(getFilmsByString, true);
            MyCommandAddFilm = new RelayCommand(toAddFilm, true);
            MyCommandDescription = new RelayCommand(getDescriptionFilm, true);
            MyCommandDelete = new RelayCommand(toDelete, true);
            MyCommandUpdate = new RelayCommand(toUpdate, true);
        }

        // modifier un film, recuperer les donnees de la liste pour les afficher
        // sur la nouvelle fenetre
        private void toUpdate()
        {
            AddFilm toto = new AddFilm();
            CloseAction();
            toto.ShowDialog();
        }

        private void toDelete()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Êtes-vous sûr de vouloir supprimer nomdufilm ?", "Supprimer un film", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                System.Windows.Forms.MessageBox.Show("nomdufilm supprimé");
            }
        }

        private void getDescriptionFilm()
        {
            FilmDescription toto = new FilmDescription();
            toto.ShowDialog();
        }


        private void getFilmsByString()
        {
            System.Windows.MessageBox.Show("Fonctionnalité bientôt disponible!");
        }

        private void toAddFilm()
        {
            AddFilm toto = new AddFilm();
            CloseAction();
            toto.ShowDialog();
        }


        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged();
            }
        }

        void MyCommandExecute()
        {
            LogIn toto = new LogIn();
            CloseAction();
            toto.ShowDialog();

        }


        bool MyCommandCanExecute()
        {
            return true;
        }
    }
}
