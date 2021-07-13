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
                if (Mode == "LOW_POWER")
                {
                    this.Position = this.Position;
                }
                else
                {                    
                    this.Mode = message.Commands[i].NewMode;
                    this.Position = message.Commands[i].NewPosition;
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
