using System;
namespace MarsRover
{
    public class Message
    {
        public string Name { get; set; }
        public Command[] Commands { get; set; }

        public Message(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "Name is required.");
            }
            this.Name = name;
        }

        public Message(Command[] commands)
        {
            this.Commands = commands;
        }

        public Message(string name, Command[] commands)
        {
            this.Name = name;
            this.Commands = commands;
        }
    }
}
