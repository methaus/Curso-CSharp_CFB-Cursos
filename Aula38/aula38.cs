using System;

namespace Aula38 {
    class Personagem {
        protected string nome;
        protected int energia;
        protected bool vivo;
        public Personagem(string nome, int energia) {
            this.nome = nome;
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
        virtual public void setDeath() {
            energia = 0;
            vivo = false;
            Console.WriteLine("Personagem {0} morreu...",nome);
        }
        public void getEnergia() {
            Console.WriteLine("{0} com {1} de energia.",nome,energia);
        }
    }
    class Jogador:Personagem {
        public Jogador(string nome, int energia):base(nome, energia) {}
        override public void setDeath() {
            energia = 0;
            vivo = false;
            Console.WriteLine("Você morreu... GameOver!");
        }
    }
    class program {
        static void Main() {
            Personagem npc = new Personagem("NPC", 89);
            Jogador player = new Jogador("Player", 43);
            npc.getEnergia();
            npc.setDeath();
            npc.getEnergia();
            Console.WriteLine("------------------------");
            player.getEnergia();
            player.setDeath();
            player.getEnergia();
            Console.Read();
        }
    }
}