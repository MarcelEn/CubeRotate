using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeRotate
{
    interface ICubeRotationHandler
    {
        ImageDescription getFrontImage();
        ImageDescription getTopImage();
        ImageDescription getRightImage();
        ImageDescription getLeftImage();
        ImageDescription getBackImage();
        ImageDescription getBottomImage();
        void flipUp();
        void flipRight();
        void flipDown();
        void flipLeft();
        void turnRight();
        void turnLeft();
    }
}
