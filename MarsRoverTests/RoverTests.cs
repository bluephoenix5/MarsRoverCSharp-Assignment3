using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {
        Rover newRover = new Rover(1000);

        [TestMethod]
        public void ConstructorSetsDefaultPosition()
        {
            Rover newRover = new Rover(1000);
            Assert.AreEqual(newRover.Position, 1000);
        }

        [TestMethod]
        public void ConstructorSetsDefaultMode()
        {
            Rover newRover = new Rover(1000);
            Assert.AreEqual(newRover.Mode, "Normal");
        }

        [TestMethod]
        public void ConstructorSetsDefaultGeneratorWatts()
        {

        }

        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        {

        }

        [TestMethod]
        public void DoesNotMoveInLowPower()
        {

        }

        [TestMethod]
        public void PositionChangesFromMoveCommand()
        {

        }
    }
}
