using Messenger.View;
using Messenger.ViewModel.Helpers;
using Messenger.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Messenger.ViewModel
{
    internal class ClientViewModel : BindingHelper
    {
        public BindableCommand back { get; set; }
        public void backk1()
        {
            MainWindow second_window = new MainWindow();
            second_window.Show();
            Application.Current.Windows[0].Close();
        }

        public ClientViewModel()
        {

            back = new BindableCommand(_ => backk1());


        }
    }
}
