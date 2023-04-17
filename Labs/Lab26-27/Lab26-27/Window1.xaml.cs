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
using System.Windows.Shapes;

namespace Lab26_27
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void textBoxOne_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["ActiveTextBoxStyle"];
        }

        private void textBoxOne_LostFocus(object sender, RoutedEventArgs e)
        {
            (sender as FrameworkElement).Style = (Style)Resources["InactiveTextBoxStyle"];
        }
    }
}
