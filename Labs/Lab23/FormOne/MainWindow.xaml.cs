using System;
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

namespace FormOne
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

        private void ButtonHide_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Visibility = Visibility.Hidden;
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Clear();
        }

        private void ButtonShow_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Visibility = Visibility.Visible;
        }
    }
}
