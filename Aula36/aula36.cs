using System;

namespace Aula36 {
    class Personagem {
        private string name;
        private int energia;
        private bool vivo;
        public Personagem(string name, int energia) {
            this.name = name;
            if (energia > 1) {
                if (energia < 100) {
                    this.energia = energia;
                } else {
                    this.energia = 100;
                }
            } else {
                this.energia = 0;
            }

            if (this.energia > 0) {
                vivo = true;
            } else {
                vivo = false;
            }
        }
        protected string getName() {
            return name;
        }
        protected int getEnergia() {
            return energia;
        }
        protected bool getVivo() {
            return vivo;
        }
    }
    class Jogador:Personagem {
        private int gold;
        public Jogador(string name, int energia, int gold):base(name, energia) {
            this.gold = gold;
        }
        public void getInfo() {
            Console.WriteLine("Nome...: {0}\nGold...: {1}\nEnergia: {2}\nVivo...: {3}",getName(),gold,getEnergia(),getVivo());
        }
    }
    class program {
        static void Main() {
            Jogador j1 = new Jogador("Player_1", 68, 1327);
            j1.getInfo();
            Console.Read();
        }
    }
}