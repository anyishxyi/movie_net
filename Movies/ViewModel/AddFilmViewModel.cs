using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;

namespace Movies
{
    class AddFilmViewModel : ViewModelBase
    {
        public Action CloseAction { get; set; }

        public RelayCommand TryRegisterFilm { get; }
        public RelayCommand Home { get; }


        public AddFilmViewModel()
        {
            TryRegisterFilm = new RelayCommand(AddFilm, true);
            Home = new RelayCommand(ReturnHome, true);

        }

        private void ReturnHome()
        {
            MainWindow toto = new MainWindow();
            CloseAction();
            toto.Show();
        }

        private void AddFilm()
        {
            MessageBox.Show("Merci pour l'ajout du film");
            CloseAction();
        }


    }
}
