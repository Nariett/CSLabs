using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int count = 0;
        public static int ques = 0;
        private void Canvas1_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(1);
        }
        private void Canvas2_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(2);
        }
        private void Canvas3_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(3);
        }
        private void Canvas4_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(4);
        }
        private void Canvas5_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(5);
        }
        private void Canvas6_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(6);
        }
        private void Canvas7_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(7);
        }
        private void Canvas8_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(8);
        }
        private void Canvas9_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(9);
        }
        private void Canvas10_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(10);
        }
        private void Canvas11_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(11);
        }
        private void Canvas12_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(12);
        }
        private void Canvas13_Click(object sender, RoutedEventArgs e)
        {
            ShowCanvas(13);
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            start.Visibility = Visibility.Collapsed;
            canvas1.Visibility = Visibility.Visible;
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)//состав дошик
        {
            SelectionСheck(Q1D, Q1R, One, canvas1, canvas2);
        }
        private void ButtonNext2_Click(object sender, RoutedEventArgs e)//еда в коробке дошик
        {
            SelectionСheck(Q2D, Q2R, Two, canvas2, canvas3);
        }
        private void ButtonNext3_Click(object sender, RoutedEventArgs e)//кто раньше дошик
        {
            SelectionСheck(Q3D, Q3R, Three, canvas3, canvas4);
        }
        private void ButtonNext4_Click(object sender, RoutedEventArgs e)//завод дошик
        {
            SelectionСheck(Q4D, Q4R, Four, canvas4, canvas5);
        }
        private void ButtonNext5_Click(object sender, RoutedEventArgs e)//буква роллтон
        {
            SelectionСheck(Q5R, Q5D, Five, canvas5, canvas6);
        }
        private void ButtonNext6_Click(object sender, RoutedEventArgs e)//реклама дошик
        {
            SelectionСheck(Q6D, Q6R, Six, canvas6, canvas7);
        }
        private void ButtonNext7_Click(object sender, RoutedEventArgs e)//вилка ролтон
        {
            SelectionСheck(Q7R, Q7D, Seven, canvas7, canvas8);
        }
        private void ButtonNext8_Click(object sender, RoutedEventArgs e)//упаковка дошик
        {
            SelectionСheck(Q8D, Q8R, Eight, canvas8, canvas9);
        }
        private void ButtonNext9_Click(object sender, RoutedEventArgs e)//как внутри ролтик
        {
            SelectionСheck(Q9R, Q9D, Nine, canvas9, canvas10);
        }
        private void ButtonNext10_Click(object sender, RoutedEventArgs e)//посыпка дошик
        {
            SelectionСheck(Q10D, Q10R, Ten, canvas10, canvas11);
        }
        private void ButtonNext11_Click(object sender, RoutedEventArgs e)//мясо ролтик
        {
            SelectionСheck(Q11R, Q11D, Eleven, canvas11, canvas12);
        }
        private void ButtonNext12_Click(object sender, RoutedEventArgs e)//приправа дошик
        {
            SelectionСheck(Q12D, Q12R, Twelve, canvas12, canvas13);
        }
        private void ButtonNext13_Click(object sender, RoutedEventArgs e)//заварился ролтон
        {
            if (Q13R.IsChecked == true && Q13D.IsChecked == false)
            {
                Q13R.IsHitTestVisible = false;
                Q13D.IsHitTestVisible = false;
                Thirteen.Background = Brushes.Green;
                count++;
                ShowScore();
            }
            else if (Q13R.IsChecked == true && Q13D.IsChecked == true)
            {
                MessageBox.Show("Выберите один вариант");
            }
            else if (Q13R.IsChecked == false && Q13D.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else if (Q13R.IsHitTestVisible == false)
            {
                canvas13.Visibility = Visibility.Collapsed;
                finish.Visibility = Visibility.Visible;
            }
            else
            {
                Q13R.IsHitTestVisible = false;
                Q13D.IsHitTestVisible = false;
                Thirteen.Background = Brushes.Red;
                ques++;
            }
            if (ques != 13)
            {
                MessageBox.Show("Пройдите оставшиеся уровни!");
            }
            else
            {
                canvas13.Visibility = Visibility.Collapsed;
                finish.Visibility = Visibility.Visible;
                Result.Content = count + "/13";
            }
        }
        public void SelectionСheck(CheckBox TrueBox, CheckBox Two, Button numberQue, Canvas canvasOne, Canvas canvasTwo)
        {
            if (TrueBox.IsChecked == true && Two.IsChecked == false && TrueBox.IsHitTestVisible == true)
            {
                TrueBox.IsHitTestVisible = false;
                Two.IsHitTestVisible = false;
                numberQue.Background = Brushes.Green;
                canvasOne.Visibility = Visibility.Collapsed;
                canvasTwo.Visibility = Visibility.Visible;
                count++; 
                ques++;
                ShowScore();
            }
            else if (TrueBox.IsChecked == true && Two.IsChecked == true)
            {
                MessageBox.Show("Выберите один вариант");
            }
            else if (TrueBox.IsChecked == false && Two.IsChecked == false)
            {
                MessageBox.Show("Выберите вариант ответа");
            }
            else if(TrueBox.IsHitTestVisible == false)
            {
                canvasOne.Visibility = Visibility.Collapsed;
                canvasTwo.Visibility = Visibility.Visible;
            }
            else
            {
                TrueBox.IsHitTestVisible = false;
                Two.IsHitTestVisible = false;
                numberQue.Background = Brushes.Red;
                canvasOne.Visibility = Visibility.Collapsed;
                canvasTwo.Visibility = Visibility.Visible;
                ques++;
            }
            if (ques == 13)
            {
                finish.Visibility = Visibility.Visible;
                Result.Content = count + "/13";
            }

        }
        private void ShowCanvas(int canvasIndex)
        {
            canvas1.Visibility = Visibility.Collapsed;
            canvas2.Visibility = Visibility.Collapsed;
            canvas3.Visibility = Visibility.Collapsed;
            canvas4.Visibility = Visibility.Collapsed;
            canvas5.Visibility = Visibility.Collapsed;
            canvas6.Visibility = Visibility.Collapsed;
            canvas7.Visibility = Visibility.Collapsed;
            canvas8.Visibility = Visibility.Collapsed;
            canvas9.Visibility = Visibility.Collapsed;
            canvas10.Visibility = Visibility.Collapsed;
            canvas11.Visibility = Visibility.Collapsed;
            canvas12.Visibility = Visibility.Collapsed;
            canvas13.Visibility = Visibility.Collapsed;
            switch (canvasIndex)
            {
                case 1:
                    canvas1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    canvas2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    canvas3.Visibility = Visibility.Visible;
                    break;
                case 4:
                    canvas4.Visibility = Visibility.Visible;
                    break;
                case 5:
                    canvas5.Visibility = Visibility.Visible;
                    break;
                case 6:
                    canvas6.Visibility = Visibility.Visible;
                    break;
                case 7:
                    canvas7.Visibility = Visibility.Visible;
                    break;
                case 8:
                    canvas8.Visibility = Visibility.Visible;
                    break;
                case 9:
                    canvas9.Visibility = Visibility.Visible;
                    break;
                case 10:
                    canvas10.Visibility = Visibility.Visible;
                    break;
                case 11:
                    canvas11.Visibility = Visibility.Visible;
                    break;
                case 12:
                    canvas12.Visibility = Visibility.Visible;
                    break;
                case 13:
                    canvas13.Visibility = Visibility.Visible;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(canvasIndex), "Ошибка");
            }
        }
        public void ShowScore()
        {
            Score.Text = count.ToString() + "/13";
        }
    }
}
