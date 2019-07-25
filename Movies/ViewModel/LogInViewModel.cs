using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Movies
{
    public class LogInViewModel : ViewModelBase
    {
        private string _name;
        private string _password;


        public Action CloseAction { get; set; }
        /**
         * Si le mot de passe est bon on ferme cette fenêtre
         * Si click sur bouton retour on ferme cette fenêtre
         * sinon on reste
         */




        public void Execute(object parameter)
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
        }

        public LogInViewModel()
        {
            MyCommandRegister = new RelayCommand(ToRegister, true);
            MyCommandConnect = new RelayCommand(MyCommandExecuteConnect, true);
            Home = new RelayCommand(ReturnHome, true);
        }

        private void ReturnHome()
        {
            MainWindow toto = new MainWindow();
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

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand Home { get; }

        public RelayCommand MyCommandRegister { get; }
        public RelayCommand MyCommandConnect { get; }


        void ToRegister()
        {
            Registration toto = new Registration();
            CloseAction();
            toto.ShowDialog();
        }

        void MyCommandExecuteConnect()
        {
            if (Name != null)
                if (Name.Equals("toto"))
                    MessageBox.Show("Good, " + Name + "!");
                else
                    MessageBox.Show("Sorry. You cannot access this page.");
        }

        bool MyCommandCanExecute()
        {
            return true;
        }

    }
}