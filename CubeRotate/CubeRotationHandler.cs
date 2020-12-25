﻿using System;
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

        public void flipUp()
        {
            var newImageDescriptions = new List<ImageDescription>();
            newImageDescriptions.Add(getTopImage());
            newImageDescriptions.Add(getBackImage());
            newImageDescriptions.Add(getBottomImage());
            newImageDescriptions.Add(getFrontImage());
            newImageDescriptions.Add(getRightImage());
            newImageDescriptions.Add(getLeftImage());

            imageDescriptions = newImageDescriptions;

            getRightImage().Direction = turnLeft(getRightImage().Direction);
            getLeftImage().Direction = turnRight(getLeftImage().Direction);
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



        public void flipRight()
        {
            throw new NotImplementedException();
        }

        public void flipDown()
        {
            throw new NotImplementedException();
        }

        public void flipLeft()
        {
            throw new NotImplementedException();
        }

        public void turnRight()
        {
            throw new NotImplementedException();
        }

        public void turnLeft()
        {
            throw new NotImplementedException();
        }

      
    }
}
