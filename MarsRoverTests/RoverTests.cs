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
            Command[] commands =
            {
                new Command("MODE", "NORMAL"),
                new Command("MOVE", 10000)
            };

            Message newMessage = new Message("Message 1", commands);

            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual(newRover.Mode, "NORMAL");
        }

        [TestMethod]
        public void DoesNotMoveInLowPower()
        {
            Command[] commands =
            {
                new Command("MODE", "LOW_POWER"),
                new Command("MOVE", 5000)
            };

            Message newMessage = new Message("Message 2", commands);

            newRover.ReceiveMessage(newMessage);
            Assert.AreNotEqual(newRover.Position, 5000);
        }

        [TestMethod]
        public void PositionChangesFromMoveCommand()
        {
            Command[] commands =
            {
                new Command("MODE", "NORMAL"),
                new Command("MOVE", 3000)
            };

            Message newMessage = new Message("Message 3", commands);

            newRover.ReceiveMessage(newMessage);
            Assert.AreEqual(newRover.Position, 3000);
        }
    }
}
