namespace Assigment_9___Individual_Part {
    public class Decorator : baseplayer {
        protected baseplayer _playerStats;
        protected baseplayer _tall;
        protected baseplayer _flower;
        protected baseplayer _star;

        public Decorator(baseplayer playerStats, baseplayer tall, baseplayer flower, baseplayer star) {
            _playerStats = playerStats;
            

        }
        
        public override void Display() {
            _playerStats.Display();
        }
    }
}