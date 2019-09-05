using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;

using backend;

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

            IMovieBackend movieBackend = MovieBackend.Instance;

            List<movie> items = movieBackend.getAllMovies();

            listbox1.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listbox1.ItemsSource);
            view.Filter = MovieFilter;

            MainViewModel vm = new MainViewModel();
            this.DataContext = vm;
            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);
        }

        private bool MovieFilter(object item)
        {
            if (String.IsNullOrEmpty(txt_search.Text))
                return true;
            else
                return ((item as movie).title.IndexOf(txt_search.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        // filtrage des donnees
        // cela va nous permettre d'écrire un texte pour filtrer les films présent dans la liste
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(listbox1.ItemsSource).Refresh();
        }

        // Si un item est selectionne on peut agir dessus par la suite
        // Faire attention au code behind une fois l'implementation reussie
        private void Listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected.Content = "";
            movie mv = listbox1.SelectedItem as movie;
            if (mv != null) { 
            string mvName = Convert.ToString(mv.title);
            string mvGenre = Convert.ToString(mv.category);
            //System.Windows.MessageBox.Show(mvName + "est du genre " + mvGenre);
            selected.Content += (selected.Content.Equals("") ? "" : ",") + mv.title;
        }
    }
    }
}
