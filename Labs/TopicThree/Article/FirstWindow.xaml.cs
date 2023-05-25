using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace Article
{
    /// <summary>
    /// Логика взаимодействия для FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
        }
        private void OpenSaveFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "C:\\";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            bool? result = saveFileDialog.ShowDialog();
            if (result == true)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, TextBlock.Text);
                MessageBox.Show("Файл успешно сохранен");
            }
        }

        private void MenuItemSave_Click(object sender, RoutedEventArgs e)
        {
            OpenSaveFileDialog();

        }

        private void MenuItemSeal_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if(printDialog.ShowDialog() == true)
            {
                FlowDocument document = new FlowDocument(new Paragraph(new Run(TextBlock.Text)));
                document.PagePadding = new Thickness(50);
                document.FontSize = 12;
                IDocumentPaginatorSource paginatorSource = document;
                printDialog.PrintDocument(paginatorSource.DocumentPaginator, "Print Text");
            }
        }

        private void MenuItemSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LeaveInMainPage_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Leave_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vkontakte.ru/share.php?url=https%3A%2F%2Fwww.wonderzine.com%2Fwonderzine%2Flife%2Fhow-to%2F237881-envy");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Process.Start("https://www.facebook.com/sharer.php?u=https%3A%2F%2Fwww.wonderzine.com%2Fwonderzine%2Flife%2Fhow-to%2F237881-envy");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("https://twitter.com/share?url=https%3A%2F%2Fwww.wonderzine.com%2Fwonderzine%2Flife%2Fhow-to%2F237881-envy&lang=en&text=%D0%95%D1%81%D0%BB%D0%B8%20%D0%B2%D0%B0%D0%BC%20%D0%BA%D0%B0%D0%B6%D0%B5%D1%82%D1%81%D1%8F,%0D%0A%D1%87%D1%82%D0%BE%20%D0%B2%D1%8B%20%D1%85%D1%83%D0%B6%D0%B5%20%D0%B4%D1%80%D1%83%D0%B3%D0%B8%D1%85:%0D%0A%D0%9A%D0%B0%D0%BA%20%D0%B8%D0%B7%D0%B2%D0%BB%D0%B5%D1%87%D1%8C%20%D0%BF%D0%BE%D0%BB%D1%8C%D0%B7%D1%83%0D%0A%D0%B8%D0%B7%20%D0%B7%D0%B0%D0%B2%D0%B8%D1%81%D1%82%D0%B8%20&via=wonderzine");
        }
    }
}
