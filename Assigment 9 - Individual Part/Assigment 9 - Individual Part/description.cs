using System;

namespace Assigment_9___Individual_Part {
    public class description : baseplayer {

        private string _playerBase;
        private string _tall;
        private string _flowerBall;
        private string _star;


        public description(string playerBase, string tall, string flowerBall, string star) {
            _playerBase = playerBase;
            _tall = tall;
            _flowerBall = flowerBall;
            _star = star;
        } 
        
        
        public override void Display() {
            Console.WriteLine("Player: {0}",_playerBase);
            Console.WriteLine("WoW: {0}",_tall);
            Console.WriteLine("Hey: {0}",_flowerBall);
            Console.WriteLine("Lol: {0}",_star);
        }
    }
}