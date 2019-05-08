using System;

namespace Assigment_9___Individual_Part {
    public class Player:baseplayer{
            private string _playerBase;

            public Player(string playerBase) {
                _playerBase = playerBase;
            }
            
            public override void Display()
            {
                Console.WriteLine("Player: {0}",_playerBase);
            }
        }
    }