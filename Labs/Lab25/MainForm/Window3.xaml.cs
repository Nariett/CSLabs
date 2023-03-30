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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[,] arr = new int[5, 5];
            string text = this.TextBoxOne.Text;
            string[] line = text.Split('_');
            for(int i = 0; i < 5;i++)
            {
                string[] item = line[i].Split(' ');
                for(int j = 0; j < 5;j++)
                {
                    arr[i,j] = Convert.ToInt32(item[j]);
                }
            }
            this.TextBoxOne.Clear();
            int count = 0;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j < 5; j++)
                {
                    if (arr[i,j] > 0)
                    {
                        count++;
                    }
                }
            }
            if (count < 3)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if(arr[i,j] > 0)
                        {
                            this.TextBoxOne.Text+=arr[i,j].ToString() + " ";
                        }
                    }
                    this.TextBoxOne.Text += Environment.NewLine;
                }
            }
            else
            {
                if (count >= 3)
                {
                    for(int i = 0; i < 5;i++)
                    {
                        sum += arr[i, i];
                    }
                    this.TextBoxOne.Text += sum;
                }

            }
            //this.TextBoxOne.Text = count.ToString();

        }
    }
}
