using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography.Pkcs;
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

namespace WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool flag = false;
                int count = 0;
                string text = this.TextBox.Text;
                string clearText = "";
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '?') count++;
                }
                if (count < 2) throw new Exception("Отсутсвует закрывающий '?'");
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '?' && flag == true)
                    {
                        flag = false;
                    }
                    if (text[i] == '?' && flag == false)
                    {
                        flag = true;
                    }
                    if (!flag)
                    {
                        clearText += text[i];
                    }
                    else if (text[i] != ' ')
                    {
                        clearText += text[i];
                    }
                }
                this.TextBox.Clear();
                this.TextBox.Text = clearText;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
