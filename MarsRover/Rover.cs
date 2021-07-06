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
            string MODE_CHANGE = Mode;
            int MOVE = Position;
        }

        public Rover(int position)
        {
           this.Position = position;
        }

        public Rover(string mode, int generatorWatts)
        {
            this.Mode = mode;
            this.GeneratorWatts = generatorWatts;
        }
                
       public override string ToString()
        {
            return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts; 
        }

    }
}
