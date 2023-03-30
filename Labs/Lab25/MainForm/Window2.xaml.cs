using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            string text = this.TextBoxOne.Text;
            string[] arrayText = text.Split(' ');
            int[] array = new int[text.Length];
            for(int i = 0; i < arrayText.Length;i++)
            {
                array[i] = Convert.ToInt32(arrayText[i]);
            }
            this.TextBoxOne.Text += Environment.NewLine;
            for(int i = 0; i < arrayText.Length;i++)
            {
                if(array[i]%7 == 1 || array[i]%7 ==2 || array[i]%7 == 5)
                {
                    this.TextBoxOne.Text += array[i] + " ";
                }
            }
        }
    }
}
