using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows;

namespace Form2
{
    /// <summary>
    /// Логика взаимодействия для InputForm.xaml
    /// </summary>
    public partial class InputForm : Window
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            MainWindow form = (MainWindow)this.Owner;
            form.ResultData = GetData();
            this.Close();
        }
        public int GetData()
        {
            int sum = 0;
            int NumOne = Convert.ToInt32(this.TextBoxOne.Text);
            int NumTwo = Convert.ToInt32(this.TextBoxTwo.Text);
            int NumThree = Convert.ToInt32(this.TextBoxThree.Text);
            if (CheckBoxOne.IsChecked == true && CheckBoxTwo.IsChecked == true)
            {
                return 0;
            }
            if (CheckBoxOne.IsChecked == true)
            {
                sum = NumOne + NumTwo + NumThree;
                //MessageBox.Show($"{sum}", "Info");
                return sum;
            }
            if (CheckBoxTwo.IsChecked == true)
            {

                int maxNum = Math.Max(NumOne, NumTwo);
                for (int i = maxNum; ; i++)
                {
                    if (i % NumOne == 0 && i % NumTwo == 0)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }
    }
}
