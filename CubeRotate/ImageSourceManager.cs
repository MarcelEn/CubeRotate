using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CubeRotate
{
    class ImageSourceManager
    {
        private List<ImageLocation> imageLocations;

        public ImageSourceManager()
        {
            imageLocations = new List<ImageLocation>();
            addLocation(1, ImageKey.FRONT);
            addLocation(2, ImageKey.TOP);
            addLocation(3, ImageKey.BACK);
            addLocation(4, ImageKey.BOTTOM);
            addLocation(5, ImageKey.RIGHT);
            addLocation(6, ImageKey.LEFT);
        }

        private void addLocation(int i, ImageKey imageKey)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(i + ".PNG", UriKind.Relative);
            bitmapImage.EndInit();

            imageLocations.Add(new ImageLocation()
            {
                Key = imageKey,
                Image = bitmapImage
            }); ;
        }

        public BitmapImage getImageByKey(ImageKey key)
        {
            return imageLocations.Find(image => image.Key == key).Image;
        }
    }

    class ImageLocation
    {
        public ImageKey Key { get; set; }
        public BitmapImage Image;
        
   }
}
