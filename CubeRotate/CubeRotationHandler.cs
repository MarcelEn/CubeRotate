using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private Direction turnRight(Direction currentDirection)
        {
            switch(currentDirection)
            {
                case Direction.NORTH:
                    return Direction.EAST;
                case Direction.EAST:
                    return Direction.SOUTH;
                case Direction.SOUTH:
                    return Direction.WEST;
                default:
                    return Direction.NORTH;
            }
        }
        private Direction turnLeft(Direction currentDirection)
        {
            switch (currentDirection)
            {
                case Direction.NORTH:
                    return Direction.WEST;
                case Direction.EAST:
                    return Direction.NORTH;
                case Direction.SOUTH:
                    return Direction.EAST;
                default:
                    return Direction.SOUTH;
            }
        }
        private ImageDescription turnRight(ImageDescription imageDescription)
        {
            imageDescription.Direction = turnRight(imageDescription.Direction);
            return imageDescription;
        }

        private ImageDescription turnLeft(ImageDescription imageDescription)
        {
            imageDescription.Direction = turnLeft(imageDescription.Direction);
            return imageDescription;
        }

        public void flipUp()
        {
            imageDescriptions = new List<ImageDescription>
            {
                getBottomImage(),
                getFrontImage(),
                getTopImage(),
                getBackImage(),
                turnRight(getRightImage()),
                turnLeft(getLeftImage())
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
                turnLeft(getRightImage()),
                turnRight(getLeftImage())
            };
        }

        public void flipRight()
        {
            imageDescriptions = new List<ImageDescription>
            {
                turnLeft(getLeftImage()),
                turnLeft(getTopImage()),
                turnLeft(getRightImage()),
                turnLeft(getBottomImage()),
                turnLeft(getFrontImage()),
                turnLeft(getBackImage())
            };
        }

       

        public void flipLeft()
        {
            imageDescriptions = new List<ImageDescription>
            {
                turnRight(getRightImage()),
                turnRight(getTopImage()),
                turnRight(getLeftImage()),
                turnRight(getBottomImage()),
                turnRight(getBackImage()),
                turnRight(getFrontImage()),
            };
        }

        public void turnRight()
        {
            imageDescriptions = new List<ImageDescription>
            {
                turnRight(getFrontImage()),
                getLeftImage(),
                turnLeft(getBackImage()),
                turnRight(turnRight(getRightImage())),
                getTopImage(),
                turnRight(turnRight(getBottomImage())),
            };
        }

        public void turnLeft()
        {
            imageDescriptions = new List<ImageDescription>
            {
                turnLeft(getFrontImage()),
                getRightImage(),
                turnRight(getBackImage()),
                turnRight(turnRight(getLeftImage())),
                turnRight(turnRight(getBottomImage())),
                getTopImage(),
            };
        }

      
    }
}
