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

namespace Lab26_27
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window1 formOne = new Window1();
            formOne.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 formFour = new Window2();
            formFour.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Window4 formFour = new Window4();
            formFour.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Window5 formFive = new Window5();
            formFive.Show();
        }
    }
}
