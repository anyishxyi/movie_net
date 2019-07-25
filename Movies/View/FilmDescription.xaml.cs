using System;
using System.Windows;

namespace Movies
{
    /// <summary>
    /// Logique d'interaction pour FilmDescription.xaml
    /// </summary>
    public partial class FilmDescription : Window
    {
        public FilmDescription()
        {
            InitializeComponent();
            FilmDescriptionViewModel vm = new FilmDescriptionViewModel();
            this.DataContext = vm;
            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
