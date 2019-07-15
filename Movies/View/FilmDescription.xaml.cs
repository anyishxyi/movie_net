using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
    }
}
