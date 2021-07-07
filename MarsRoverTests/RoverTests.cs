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
        //Rover newReceiveMessage = new Message("NORMAL");
        //string[] MODE_CHANGE = { "LOW_POWER", "NORMAL" };

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
            Assert.AreEqual(newRover.Mode, "NORMAL");
        }

        [TestMethod]
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Rover newRover = new Rover(1000);
            Assert.AreEqual(newRover.GeneratorWatts, 110);
        }

        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        {
            newRover.ReceiveMessage(message);
            Assert.AreEqual(newRover.Position, 5000);
        }

        //[TestMethod]
        //public void DoesNotMoveInLowPower()
        //{

        //}

        //[TestMethod]
        //public void PositionChangesFromMoveCommand()
        //{

        //}
    }
}
