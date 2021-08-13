using System;

namespace Aula43 {
    public interface Ente {
        void setEnergia(int energia);
        void Info();
    }
    class Personagem:Ente {
        private string name;
        private int energia;
        public Personagem(string name, int energia) {
            this.name = name;
            setEnergia(energia);
        }
        public void setEnergia(int energia) {
            if (energia < 1) {
                this.energia = 0;
            } else if (energia < 100) {
                this.energia = energia;
            } else {
                this.energia = 100;
            }
        }
        public void Info() {
            Console.WriteLine("{0} tem energia {1}",name,energia);
        }
    }
    class program {
        static void Main() {
            Personagem player = new Personagem("Jogador", 999);
            player.Info();
            Console.Read();
        }
    }
}