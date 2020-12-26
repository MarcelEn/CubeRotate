using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeRotate
{
    class ImageDescription
    {
        public Direction Direction { get; set; }
        public ImageKey Key { get; set; }

        public ImageDescription TurnRight()
        {
            Direction = TurnRight(Direction);
            return this;
        }
        public ImageDescription TurnLeft()
        {
            Direction = TurnLeft(Direction);
            return this;
        }
        public ImageDescription TurnHalf()
        {
            return TurnRight().TurnRight();
        }

        private Direction TurnRight(Direction currentDirection)
        {
            switch (currentDirection)
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
        private Direction TurnLeft(Direction currentDirection)
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
    }
    enum ImageKey
    {
        FRONT,
        TOP,
        BACK,
        BOTTOM,
        RIGHT,
        LEFT
    }
    enum Direction {
        NORTH,
        EAST,
        SOUTH,
        WEST
    }
}
