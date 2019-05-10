using System;

namespace Assigment_9___Individual_Part {
    internal class Program {
        public static void Main(string[] args) {
            IDraw idecorator = new Base();
            
            idecorator = new abstractStar(idecorator);
            idecorator = new abstractTall(idecorator);
            
            Console.WriteLine(idecorator.Draw());
            
        }
    }
}