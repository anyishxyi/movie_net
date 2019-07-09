using System;
using System.Windows;

namespace Movies
{
    /// <summary>
    /// Logique d'interaction pour AddFilm.xaml
    /// </summary>
    public partial class AddFilm : Window
    {
        public AddFilm()
        {
            InitializeComponent();

            AddFilmViewModel vm = new AddFilmViewModel();
            this.DataContext = vm;
            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);
        }
    }
}
