using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Mars Rover!");

            Rover newRover = new Rover(98382);
            Console.WriteLine(newRover.ToString());

            Command[] commands = { new Command("MODE", "LOW_POWER"), new Command("MOVE", 5000) };
            Message newMessage = new Message("Test message with two commands", commands);

            Console.WriteLine(newRover.ToString());

            newRover.ReceiveMessage(newMessage);
            Console.WriteLine(newRover.ToString());


        }
    }
}
