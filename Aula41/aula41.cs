using System;

namespace Aula41 {
    class Personagem {
        protected string charname;
        protected int charenergia;
        public string name {
            get { 
                return charname;
            }
            set { 
                charname = value;
            }
        }
        public int energia {
            get { 
                return charenergia;
            }
            set { 
                if (value < 0) {
                    charenergia = 0;
                } else if (value > 100) {
                    charenergia = 100;
                } else {
                    charenergia = value;
                }
            }
        }
    }
    class program {
        static void Main() {
            Personagem player = new Personagem();
            player.name = "Player 1";
            player.energia = 100;
            Console.WriteLine("Nome: {0}\nEnergia: {1}",player.name,player.energia);
            Console.Read();
        }
    }
}