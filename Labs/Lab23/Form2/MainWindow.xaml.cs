using System.Windows;

namespace Form2
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
        public int ResultData = 0;
        
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AboutForm x = new AboutForm();
            x.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            InputForm form = new InputForm();
            form.Owner = this;
            form.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{ResultData}", "Result");
        }
    }
}
