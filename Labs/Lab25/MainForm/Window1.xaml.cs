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

namespace MainForm
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double X0 = Convert.ToDouble(this.TextBoxOne.Text);
            double Xk = Convert.ToDouble(this.TextBoxTwo.Text);
            double Step = Convert.ToDouble(this.TextBoxThree.Text);
            for(double x = X0; x <= Xk; x+=Step)
            {
                this.TextBoxFour.Text += Math.Pow(Math.Log10(Math.Sin((Math.Pow(x, 3) + 0.0025))), 1.5) + 0.8 * Math.Pow(10, -3) + Environment.NewLine;
            }
        }
    }
}
