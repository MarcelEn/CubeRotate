using NUnit.Framework;
using System.Collections.Generic;

namespace CubeRotate
{
    class CubeRotationHandlerTest
    {

        private ICubeRotationHandler Handler;


        [SetUp]
        public void Setup() => Handler = new CubeRotationHandler();

        [Test]
        public void initializeCorrectly()
        {
            frontEqual(Direction.NORTH, ImageKey.FRONT);
            topEqual(Direction.NORTH, ImageKey.TOP);
            rightEqual(Direction.WEST, ImageKey.RIGHT);
            leftEqual(Direction.EAST, ImageKey.LEFT);
            backEqual(Direction.SOUTH, ImageKey.BACK);
            bottomEqual(Direction.SOUTH, ImageKey.BOTTOM);
        }

        [Test]
        public void itCorrectlyFlipsUp()
        {
            Handler.flipUp();


            frontEqual(Direction.SOUTH, ImageKey.BOTTOM);
            topEqual(Direction.NORTH, ImageKey.FRONT);
            backEqual(Direction.NORTH, ImageKey.TOP);
            bottomEqual(Direction.SOUTH, ImageKey.BACK);

            leftEqual(Direction.NORTH, ImageKey.LEFT);
            rightEqual(Direction.NORTH, ImageKey.RIGHT);
        }

        [Test]
        public void itCorrectlyFlipsDown()
        {
            Handler.flipDown();


            frontEqual(Direction.NORTH, ImageKey.TOP);
            topEqual(Direction.SOUTH, ImageKey.BACK);
            backEqual(Direction.SOUTH, ImageKey.BOTTOM);
            bottomEqual(Direction.NORTH, ImageKey.FRONT);

            leftEqual(Direction.SOUTH, ImageKey.LEFT);
            rightEqual(Direction.SOUTH, ImageKey.RIGHT);
        }
        [Test]
        public void itCorrectlyFlipsRight()
        {
            Handler.flipRight();

            frontEqual(Direction.NORTH, ImageKey.LEFT);
            backEqual(Direction.SOUTH, ImageKey.RIGHT);
            rightEqual(Direction.WEST, ImageKey.FRONT);
            leftEqual(Direction.EAST, ImageKey.BACK);

            bottomEqual(Direction.EAST, ImageKey.BOTTOM);
            topEqual(Direction.WEST, ImageKey.TOP);

        }

        private void frontEqual(Direction direction, ImageKey key)
        {
            Assert.AreEqual(direction, Handler.getFrontImage().Direction);
            Assert.AreEqual(key, Handler.getFrontImage().Key);
        }
        private void topEqual(Direction direction, ImageKey key)
        {
            Assert.AreEqual(direction, Handler.getTopImage().Direction);
            Assert.AreEqual(key, Handler.getTopImage().Key);
        }
        private void rightEqual(Direction direction, ImageKey key)
        {
            Assert.AreEqual(direction, Handler.getRightImage().Direction);
            Assert.AreEqual(key, Handler.getRightImage().Key);
        }
        private void leftEqual(Direction direction, ImageKey key)
        {
            Assert.AreEqual(direction, Handler.getLeftImage().Direction);
            Assert.AreEqual(key, Handler.getLeftImage().Key);
        }
        private void backEqual(Direction direction, ImageKey key)
        {
            Assert.AreEqual(direction, Handler.getBackImage().Direction);
            Assert.AreEqual(key, Handler.getBackImage().Key);
        }
        private void bottomEqual(Direction direction, ImageKey key)
        {
            Assert.AreEqual(direction, Handler.getBottomImage().Direction);
            Assert.AreEqual(key, Handler.getBottomImage().Key);
        }
    }
}
