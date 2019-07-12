using System;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Movies
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand MyCommandConnect { get; }
        public RelayCommand MyCommandAddFilm { get; }
        public RelayCommand MyCommandFind { get; }

        private string _name;

        public Action CloseAction { get; set; }

        public FontStyle FontStyleTreeItem { get; set; }




        public MainViewModel()
        {
            FontStyleTreeItem = FontStyles.Italic;
            Name = "Veuillez vous identifier";
            MyCommandConnect = new RelayCommand(MyCommandExecute, MyCommandCanExecute);
            MyCommandFind = new RelayCommand(getFilmsByString, true);
            MyCommandAddFilm = new RelayCommand(toAddFilm, true);

        }

        private void getFilmsByString()
        {
            MessageBox.Show("Fonctionnalité bientôt disponible!");
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
