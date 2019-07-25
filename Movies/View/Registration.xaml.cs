using System;
using System.Windows;

namespace Movies
{
    /// <summary>
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();

            RegistrationViewModel vm = new RegistrationViewModel();
            this.DataContext = vm;
            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);
        }
    }
}
