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
