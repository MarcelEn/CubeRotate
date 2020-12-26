using NUnit.Framework;

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
            backEqual(Direction.SOUTH, ImageKey.BACK);
            bottomEqual(Direction.SOUTH, ImageKey.BOTTOM);
            rightEqual(Direction.WEST, ImageKey.RIGHT);
            leftEqual(Direction.EAST, ImageKey.LEFT);
        }

        [Test]
        public void itCorrectlyFlipsUp()
        {
            Handler.flipUp();

            frontEqual(Direction.SOUTH, ImageKey.BOTTOM);
            topEqual(Direction.NORTH, ImageKey.FRONT);
            backEqual(Direction.NORTH, ImageKey.TOP);
            bottomEqual(Direction.SOUTH, ImageKey.BACK);
            rightEqual(Direction.NORTH, ImageKey.RIGHT);
            leftEqual(Direction.NORTH, ImageKey.LEFT);
        }

        [Test]
        public void itCorrectlyFlipsDown()
        {
            Handler.flipDown();

            frontEqual(Direction.NORTH, ImageKey.TOP);
            topEqual(Direction.SOUTH, ImageKey.BACK);
            backEqual(Direction.SOUTH, ImageKey.BOTTOM);
            bottomEqual(Direction.NORTH, ImageKey.FRONT);
            rightEqual(Direction.SOUTH, ImageKey.RIGHT);
            leftEqual(Direction.SOUTH, ImageKey.LEFT);
        }

        [Test]
        public void itCorrectlyFlipsRight()
        {
            Handler.flipRight();

            frontEqual(Direction.NORTH, ImageKey.LEFT);
            topEqual(Direction.WEST, ImageKey.TOP);
            backEqual(Direction.SOUTH, ImageKey.RIGHT);
            bottomEqual(Direction.EAST, ImageKey.BOTTOM);
            rightEqual(Direction.WEST, ImageKey.FRONT);
            leftEqual(Direction.EAST, ImageKey.BACK);

        }

        [Test]
        public void itCorrectlyFlipsLeft()
        {
            Handler.flipLeft();

            frontEqual(Direction.NORTH, ImageKey.RIGHT);
            topEqual(Direction.EAST, ImageKey.TOP);
            backEqual(Direction.SOUTH, ImageKey.LEFT);
            bottomEqual(Direction.WEST, ImageKey.BOTTOM);
            rightEqual(Direction.WEST, ImageKey.BACK);
            leftEqual(Direction.EAST, ImageKey.FRONT);
        }

        [Test]
        public void itCorrectlyTurnsRight()
        {
            Handler.turnRight();

            frontEqual(Direction.EAST, ImageKey.FRONT);
            topEqual(Direction.EAST, ImageKey.LEFT);
            backEqual(Direction.EAST, ImageKey.BACK);
            bottomEqual(Direction.EAST, ImageKey.RIGHT);
            rightEqual(Direction.NORTH, ImageKey.TOP);
            leftEqual(Direction.NORTH, ImageKey.BOTTOM);
        }

        [Test]
        public void itCorrectlyTurnsLeft()
        {
            Handler.turnLeft();

            frontEqual(Direction.WEST, ImageKey.FRONT);
            topEqual(Direction.WEST, ImageKey.RIGHT);
            backEqual(Direction.WEST, ImageKey.BACK);
            bottomEqual(Direction.WEST, ImageKey.LEFT);
            rightEqual(Direction.NORTH, ImageKey.BOTTOM);
            leftEqual(Direction.NORTH, ImageKey.TOP);
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
