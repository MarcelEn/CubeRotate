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

        private ICubeRotationHandler cubeRotationHandler;
        private ImageSourceManager imageSourceManager;
        private Image front, top, right;
        private RotateTransform frontRotateTransform, topRotateTransform, rightRotateTransform;
        
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            cubeRotationHandler = new CubeRotationHandler();
            imageSourceManager = new ImageSourceManager();
            front = (Image)FindName("frontImage");
            top = (Image)FindName("topImage");
            right = (Image)FindName("rightImage");
            frontRotateTransform = (RotateTransform)FindName("frontRotate");
            topRotateTransform = (RotateTransform)FindName("topRotate");
            rightRotateTransform = (RotateTransform)FindName("rightRotate");

            updateImages();
        }

        private void updateImages()
        {
            front.Source = imageSourceManager.getImageByKey(cubeRotationHandler.getFrontImage().Key);
            right.Source = imageSourceManager.getImageByKey(cubeRotationHandler.getRightImage().Key);
            top.Source = imageSourceManager.getImageByKey(cubeRotationHandler.getTopImage().Key);

            rightRotateTransform.Angle = resolveAngel(cubeRotationHandler.getRightImage().Direction) + 90;
            topRotateTransform.Angle = resolveAngel(cubeRotationHandler.getTopImage().Direction);
            frontRotateTransform.Angle = resolveAngel(cubeRotationHandler.getFrontImage().Direction);
        }

        private double resolveAngel(Direction direction)
        {
            switch (direction)
            {
                case Direction.EAST:
                    return 90;
                case Direction.SOUTH:
                    return 180;
                case Direction.WEST:
                    return 270;
            }
            return 0;
        }

        private void onUpClick(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("UP");
            cubeRotationHandler.flipUp();
            updateImages();
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
