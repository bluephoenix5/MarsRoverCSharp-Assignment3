using System;
namespace MarsRover
{
    public class Rover
    {
        public string Mode { get; set; }
        public int Position { get; set; }
        public int GeneratorWatts { get; set; }

        public void ReceiveMessage(Message message)
        {
            for (int i = 0; i < message.Commands.Length; i++)
            {              
                if (Mode == "NORMAL")
                {
                    this.Mode = message.Commands[i].NewMode;
                    this.Position = message.Commands[i].NewPosition;
                }
                else
                {
                    this.Mode = this.Mode;
                }
            }

            
        }

        public Rover(int position)
        {
           this.Position = position;
            this.Mode = "NORMAL";
            this.GeneratorWatts = 110;
        }
                
       public override string ToString()
        {
            return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts; 
        }

    }
}
