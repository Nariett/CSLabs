using System.Windows;

namespace Lab26_27
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

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxOne.Text == "" && textBoxTwo.Text == "")
            {
                this.Close();
            }
        }

        private void ButtonClean_Click(object sender, RoutedEventArgs e)
        {
            textBoxOne.Clear();
            textBoxTwo.Clear();


        }
    }
}
