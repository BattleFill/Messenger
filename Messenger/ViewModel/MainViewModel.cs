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
    internal class MainViewModel : BindingHelper
    {
        public BindableCommand Server { get; set; }
        public BindableCommand Client { get; set; }
        public BindableCommand Nul { get; set; }


        public void Serverr()
        {
            ServerWindow second_window = new ServerWindow();
            second_window.Show();
            Application.Current.MainWindow.Close();

        }
        public void Clientt()
        {
            ClientWindow second_window = new ClientWindow();
            second_window.Show();
            Application.Current.MainWindow.Close();

        }
        public void Nulll()
        {

            Application.Current.MainWindow.Close();

        }
        public MainViewModel()
        {

            Server = new BindableCommand(_ => Serverr());
            Client = new BindableCommand(_ => Clientt());
            Nul = new BindableCommand(_ => Nulll());

        }
        

    }
}
