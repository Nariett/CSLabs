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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab26_27
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
            ellipse = new Ellipse();
            ellipse.Width = 200;
            ellipse.Height = 200;
            ellipse.Stroke = Brushes.Black;
            ellipse.StrokeThickness = 2;
            RadialGradientBrush brush = new RadialGradientBrush();
            brush.GradientStops.Add(new GradientStop(Colors.Red, 0));
            brush.GradientStops.Add(new GradientStop(Colors.Orange, 0.5));
            brush.GradientStops.Add(new GradientStop(Colors.Red, 1));
            ellipse.Fill = brush;

            mainGrid.Children.Add(ellipse);

            DoubleAnimation opacityAnimation = new DoubleAnimation();
            opacityAnimation.From = 0;
            opacityAnimation.To = 1;
            opacityAnimation.Duration = new Duration(TimeSpan.FromSeconds(2));
            opacityAnimation.AutoReverse = true;
            opacityAnimation.RepeatBehavior = RepeatBehavior.Forever;

            DoubleAnimation scaleAnimation = new DoubleAnimation();
            scaleAnimation.From = 0.5;
            scaleAnimation.To = 1;
            scaleAnimation.Duration = new Duration(TimeSpan.FromSeconds(2));
            scaleAnimation.AutoReverse = true;
            scaleAnimation.RepeatBehavior = RepeatBehavior.Forever;

            ellipse.BeginAnimation(Ellipse.OpacityProperty, opacityAnimation);

            ScaleTransform scaleTransform = new ScaleTransform(0.5, 0.5);
            ellipse.RenderTransform = scaleTransform;
            ellipse.RenderTransformOrigin = new Point(0.5, 0.5);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, scaleAnimation);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, scaleAnimation);
        }
    }
}
