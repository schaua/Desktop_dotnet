using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for ElementBindingView.xaml
    /// </summary>
    public partial class ElementBindingView : UserControl
    {
        public ElementBindingView()
        {
            InitializeComponent();
        }

        private void Size_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if ( btn.Content.ToString().Contains("24"))
            {
                // Directly setting FontSize will break the binding
                // label1.FontSize = 24;
                slider1.Value = 24;
            }
            else
            {
                slider1.Value = 36;
            }

        }
    }
}
