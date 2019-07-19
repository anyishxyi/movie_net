using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;

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


            List<Movie> items = new List<Movie>();
            items.Add(new Movie() { Name = "Mad Max", Genre = "Action" });
            items.Add(new Movie() { Name = "Anna", Genre = "Romantique" });
            items.Add(new Movie() { Name = "Lion", Genre = "Autobiographie" });
            items.Add(new Movie() { Name = "Interstellar", Genre = "Science-fiction" });
            items.Add(new Movie() { Name = "Yesterday", Genre = "Drame" });
            items.Add(new Movie() { Name = "Le Coup du siècle", Genre = "Comédie" });
            items.Add(new Movie() { Name = "Thelma", Genre = "Fantastique" });
            items.Add(new Movie() { Name = "Annabelle", Genre = "Horreur" });
            items.Add(new Movie() { Name = "Scarface", Genre = "Polar" });
            items.Add(new Movie() { Name = "Au revoir là-haut", Genre = "Historique" });
            items.Add(new Movie() { Name = "The Revenant", Genre = "Western" });
            items.Add(new Movie() { Name = "Le Roi Lion", Genre = "Aventures" });
            items.Add(new Movie() { Name = "Marguerite", Genre = "Opéra" });
            items.Add(new Movie() { Name = "Willow", Genre = "Fantasy" });
            items.Add(new Movie() { Name = "Get Out", Genre = "Thriller" });


            listbox1.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listbox1.ItemsSource);
            view.Filter = MovieFilter;







            MainViewModel vm = new MainViewModel();
            this.DataContext = vm;
            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);
        }

        public class Movie
        {
            public string Name { get; set; }

            public string Genre { get; set; }
        }
                    private bool MovieFilter(object item)
            {
                if (String.IsNullOrEmpty(txt_search.Text))
                    return true;
                else
                    return ((item as Movie).Name.IndexOf(txt_search.Text, StringComparison.OrdinalIgnoreCase) >= 0);
            }

        // filtrage des donnees
        // cela va nous permettre d'écrire un texte pour filtrer les films présent dans la liste
        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(listbox1.ItemsSource).Refresh();
        }
    }
}
// Si un item est selectionne on peut agir dessus par la suite
// Faire attention au code behind une fois l'implementation reussie
/*private void Listbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
{
    //listbox1.ItemsSource = new List<DictionaryEntry>();

    toto.Content = "";
    foreach(object movies in listbox1.SelectedItems)
    {
        toto.Content += (toto.Content.Equals("") ? "" : ",") + movies.ToString();
    }
}*/

/*            for (int i = listbox1.Items.Count - 1; i >= 0; i--)
            {
                if (listbox1.Items[i].ToString().ToLower().Contains(txt_search.Text.ToLower()))
                {
                    string a = listbox1.Items[i].ToString();
                    Console.WriteLine("Je possède "+e.OriginalSource+", je suis "+a+" avec l'ID: "+i);
                    //listbox1.ItemsSource = null;


                }
            }*/




/*                    ItemsControl.ItemsSourceProperty.
        listbox1.Items.Add(new System.Windows.Forms.ListViewItem(
            new[] { listbox1.Items[i].ToString(), listbox1.Items[i].ToString(), listbox1.Items[i].ToString()
            }));*/

/*            foreach (object movies in e)
{*/

//}

/*            for (int i = listbox1.Items.Count - 1; i >= 0; i--)
            {
                if (listbox1.Items[i].ToString().ToLower().Contains(txt_search.Text.ToLower()))
                {
                    System.w
                }

            }
 */
