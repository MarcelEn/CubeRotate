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
