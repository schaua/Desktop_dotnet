﻿using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Day1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainContent.Content = this.Resources["layoutResource"];
        }

        private void ShowPanels(object sender, RoutedEventArgs e)
        {
            mainContent.Content = this.Resources["layoutResource"];
        }

        private void ShowExample(object sender, RoutedEventArgs e)
        {
            mainContent.Content = this.Resources["exampleResource"];
        }

        private void ShowPages(object sender, RoutedEventArgs e)
        {
            mainContent.Content = this.Resources["pageResource"];
        }
    }
}
