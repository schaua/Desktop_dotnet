using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Day1.Views
{
    /// <summary>
    /// Interaction logic for MultiThreadingView.xaml
    /// </summary>
    public partial class MultiThreadingView : UserControl
    {
        public MultiThreadingView()
        {
            InitializeComponent();
        }

        private void SchedulerButton_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Add("Starting...");

            var ctx = TaskScheduler.FromCurrentSynchronizationContext();

            Task t = Task.Factory.StartNew(
                () =>
                {
                    // Do 
                    for (int i = 0; i < 10000; i++) 
                    {
                        // lstResult.Items.Add("...");
                    }
                })
                .ContinueWith(
                _ =>
                {
                    txtOne.Text = "Done";
                }, ctx);
        }

        public void DoWork(IProgress<string> progress)
        {
            if (progress != null)
                progress.Report("Starting...");

            // Do work
            for (int i = 0; i < 100; i+=10)
            {
                progress.Report(i.ToString());
            }


            if (progress != null)
                progress.Report("Finished!");
        }

        public async void AsyncButton_Click(object sender, EventArgs e)
        {
            var progress = new Progress<string>(percent =>
            {
                lstResult.Items.Add(percent + "%");
            });

            await Task.Run(() => DoWork(progress));

            txtOne.Text = "Done!";
        }
    }
}
