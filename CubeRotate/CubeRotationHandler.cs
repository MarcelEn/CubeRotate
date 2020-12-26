using System.Collections.Generic;

namespace CubeRotate
{
    class CubeRotationHandler : ICubeRotationHandler
    {
        private List<ImageDescription> imageDescriptions = new List<ImageDescription>();
        public CubeRotationHandler()
        {
            addImageDescription(Direction.NORTH, ImageKey.FRONT);
            addImageDescription(Direction.NORTH, ImageKey.TOP);
            addImageDescription(Direction.SOUTH, ImageKey.BACK);
            addImageDescription(Direction.SOUTH, ImageKey.BOTTOM);
            addImageDescription(Direction.WEST, ImageKey.RIGHT);
            addImageDescription(Direction.EAST, ImageKey.LEFT);
        }

        private void addImageDescription(Direction direction, ImageKey key)
        {
            imageDescriptions.Add(new ImageDescription
            {
                Direction = direction,
                Key = key
            });
        } 
        public ImageDescription getFrontImage()
        {
            return imageDescriptions.ToArray()[0];
        }

        public ImageDescription getRightImage()
        {
            return imageDescriptions.ToArray()[4];
        }

        public ImageDescription getTopImage()
        {
            return imageDescriptions.ToArray()[1];
        }
        public ImageDescription getLeftImage()
        {
            return imageDescriptions.ToArray()[5];
        }

        public ImageDescription getBackImage()
        {
            return imageDescriptions.ToArray()[2];
        }

        public ImageDescription getBottomImage()
        {
            return imageDescriptions.ToArray()[3];
        }

        public void flipUp()
        {
            imageDescriptions = new List<ImageDescription>
            {
                getBottomImage(),
                getFrontImage(),
                getTopImage(),
                getBackImage(),
                getRightImage().TurnRight(),
                getLeftImage().TurnLeft()
            };
        }
        public void flipDown()
        {
            imageDescriptions = new List<ImageDescription>
            {
                getTopImage(),
                getBackImage(),
                getBottomImage(),
                getFrontImage(),
                getRightImage().TurnLeft(),
                getLeftImage().TurnRight()
            };
        }

        public void flipRight()
        {
            imageDescriptions = new List<ImageDescription>
            {
                getLeftImage().TurnLeft(),
                getTopImage().TurnLeft(),
                getRightImage().TurnLeft(),
                getBottomImage().TurnLeft(),
                getFrontImage().TurnLeft(),
                getBackImage().TurnLeft()
            };
        }

       

        public void flipLeft()
        {
            imageDescriptions = new List<ImageDescription>
            {
                getRightImage().TurnRight(),
                getTopImage().TurnRight(),
                getLeftImage().TurnRight(),
                getBottomImage().TurnRight(),
                getBackImage().TurnRight(),
                getFrontImage().TurnRight()
            };
        }

        public void turnRight()
        {
            imageDescriptions = new List<ImageDescription>
            {
                getFrontImage().TurnRight(),
                getLeftImage(),
                getBackImage().TurnLeft(),
                getRightImage().TurnHalf(),
                getTopImage(),
                getBottomImage().TurnHalf()
            };
        }

        public void turnLeft()
        {
            imageDescriptions = new List<ImageDescription>
            {
                getFrontImage().TurnLeft(),
                getRightImage(),
                getBackImage().TurnRight(),
                getLeftImage().TurnHalf(),
                getBottomImage().TurnHalf(),
                getTopImage()
            };
        }

      
    }
}
