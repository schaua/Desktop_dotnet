using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HelloWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            this.Startup += MyStartUp;
        }

        private static void MyStartUp(object sender, StartupEventArgs e)
        {
            Window window = new Window();
            window.Height = 300;
            window.Width = 300;
            window.Title = "Hello WPF";

            window.Show();
        }
    }
}
