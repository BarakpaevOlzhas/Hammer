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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MsPaint
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = ellips.Width;
            animation.To = 100;
            animation.AutoReverse = true;
            animation.RepeatBehavior = RepeatBehavior.Forever;
            ellips.BeginAnimation(Ellipse.WidthProperty, animation);

        }

        private void Rectangle_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void RectangleMouseEnter(object sender, MouseEventArgs e)
        {
            rectangle.Fill = Brushes.MediumSpringGreen;
            rectangle.Stroke = Brushes.Firebrick;
        }

        private void rectangle_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void RectangleMouseLeave(object sender, MouseEventArgs e)
        {
            rectangle.Fill = Brushes.RoyalBlue;
            rectangle.Stroke = Brushes.Red;
        }
    }
}
