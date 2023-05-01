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

namespace MainForm
{
    /// <summary>
    /// Логика взаимодействия для TaskThree.xaml
    /// </summary>
    public partial class TaskThree : Window
    {
        public TaskThree()
        {
            InitializeComponent();
            var fromPoint = new Point(0.3, 0.3);
            var toPoint = new Point(0.7, 0.7);
            var animation = new PointAnimation(fromPoint, toPoint, new Duration(TimeSpan.FromSeconds(2)))
            {
                RepeatBehavior = RepeatBehavior.Forever
            };
            light.BeginAnimation(RadialGradientBrush.GradientOriginProperty, animation);

        }
    }
}
