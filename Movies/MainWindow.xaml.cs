using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace Movies
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel vm = new MainViewModel();
            this.DataContext = vm;
            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);
        }

        // filtrage des donnees
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            listbox1.SelectedItems.Clear();

            for (int i = listbox1.Items.Count - 1; i >= 0; i--)
            {
                if (listbox1.Items[i].ToString().ToLower().Contains(txt_search.Text.ToLower()))
                {
                }
                
            }
 
        }

        // Si un item est selectionne on peut agir dessus par la suite
        // Faire attention au code behind une fois l'implementation reussie
        private void Listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
