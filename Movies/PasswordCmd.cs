using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Movies
{
    public class PasswordCmd : ICommand
    {
        //public string Password;
        #region ICommand Member

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            PasswordBox boxPass = (PasswordBox)parameter;
            /*Password = boxPass.Password;

            if (Password == "toto")
            {
                MessageBox.Show("good");
            }
            else
            {
                MessageBox.Show("not good");

            }*/
        }
        #endregion
    }
}
