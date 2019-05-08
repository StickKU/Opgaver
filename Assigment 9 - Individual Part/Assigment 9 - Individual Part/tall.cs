using System;

namespace Assigment_9___Individual_Part {
    public class tall : baseplayer{
        private string _tall;

        public tall(string tall) {
            _tall = tall;
        }
            
        public override void Display()
        {
            Console.WriteLine("Tall: {0}",_tall);
        }
    }
}