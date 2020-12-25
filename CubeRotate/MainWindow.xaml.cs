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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CubeRotate
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

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            var frontPolygon = (Image) this.FindName("FrontPolygon");
            frontPolygon.Visibility = Visibility.Hidden;

            //BitmapImage bi3 = new BitmapImage();
           // bi3.BeginInit();
            //bi3.UriSource = new Uri("front-1.PNG", UriKind.Relative);
            //bi3.EndInit();
            //frontPolygon.Source = bi3;
        }

        private void onUpClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("UP");
        }
        private void onRightClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("RIGHT");
        }
        private void onDownClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("DOWN");
        }
        private void onLeftClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("LEFT");
        }
        private void onTurnLeftClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("TURN_LEFT");
        }
        private void onTurnRightClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("TURN_RIGHT");
        }
    }
}
