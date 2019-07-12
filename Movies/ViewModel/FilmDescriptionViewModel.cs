using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;

namespace Movies
{
    class FilmDescriptionViewModel : ViewModelBase
    {
        public Action CloseAction { get; set; }

        public RelayCommand Home { get; }

        public FilmDescriptionViewModel()
        {
            Home = new RelayCommand(ReturnHome, true);

        }

        private void ReturnHome()
        {
            MainWindow toto = new MainWindow();
            // trouver une solution pour le close
            toto.Show();
        }




    }
}