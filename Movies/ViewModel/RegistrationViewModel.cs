using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Movies
{
    class RegistrationViewModel : ViewModelBase
    {

        public Action CloseAction { get; set; }


        private string _name;
        private string _password;
        private string _email;

        public RegistrationViewModel()
        {
            TryRegistration = new RelayCommand(Try, true); // test la validité des données envoyées
            Home = new RelayCommand(ReturnHome, true); // retourne à l'accueil



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



        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged();
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        private void ReturnHome()
        {
            MainWindow toto = new MainWindow();
            CloseAction();
            toto.ShowDialog();
        }

        public RelayCommand TryRegistration { get; }
        public RelayCommand Home { get; }

        public Execute toto { get; private set; }

        private void Try()
        {
            if (Password != null)
                MessageBox.Show("Votre mdp est: " + Password);
            if (Name != null)
                if (Name.Equals("toto"))
                    MessageBox.Show("Good, " + Name + "!");
                else
                    MessageBox.Show("Sorry. You cannot access this page.");
        }

    }
}



/*        public void Execute(object parameter)
        {
            var passwordBox = parameter as PasswordBox;
            var password = passwordBox.Password;

            if (password == "toto")
            {
                MessageBox.Show("good");
            }
            else
            {
                MessageBox.Show("not good");

            }
        }*/

/*        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }*/
