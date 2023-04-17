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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {

            InitializeComponent();
        }
        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                TranslateTransform transform = new TranslateTransform();
                Random rnd = new Random();
                transform.X = rnd.Next(-200, 200);
                transform.Y = rnd.Next(-200, 200);
                button.RenderTransform = transform;
            }
        }
    }
}
