using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CubeRotate
{
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

            rightRotateTransform.Angle = resolveAngle(cubeRotationHandler.getRightImage().Direction) + 90;
            topRotateTransform.Angle = resolveAngle(cubeRotationHandler.getTopImage().Direction);
            frontRotateTransform.Angle = resolveAngle(cubeRotationHandler.getFrontImage().Direction);
        }

        private double resolveAngle(Direction direction)
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
            cubeRotationHandler.flipUp();
            updateImages();
        }
        private void onRightClick(object sender, RoutedEventArgs e)
        {
            cubeRotationHandler.flipRight();
            updateImages();
        }
        private void onDownClick(object sender, RoutedEventArgs e)
        {
            cubeRotationHandler.flipDown();
            updateImages();
        }
        private void onLeftClick(object sender, RoutedEventArgs e)
        {
            cubeRotationHandler.flipLeft();
            updateImages();
        }
        private void onTurnLeftClick(object sender, RoutedEventArgs e)
        {
            cubeRotationHandler.turnLeft();
            updateImages();
        }
        private void onTurnRightClick(object sender, RoutedEventArgs e)
        {
            cubeRotationHandler.turnRight();
            updateImages();
        }
    }
}
