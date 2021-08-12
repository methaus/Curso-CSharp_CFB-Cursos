using System;

namespace Aula39 {
    abstract class Personagem {
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
        abstract public void setGold(int gold);
        public string getName() {
            return nome;
        }
        public int getEnergia() {
            return energia;
        }
    }
    class Jogador:Personagem {
        public int gold;
        public Jogador(string nome, int energia, int gold):base(nome, energia) {
            this.gold = gold;
        }
        override public void setGold(int gold) {
            this.gold+= gold;
        }
    }
    class program {
        static void Main() {
            Jogador player = new Jogador("Player", 100, 1000);
            Console.WriteLine("{0} tem {1} de energia e {2} de gold.",player.getName(),player.getEnergia(),player.gold);
            Console.Write("Adicionar ouro (uma vez): ");
            player.setGold(int.Parse(Console.ReadLine()));
            Console.WriteLine("{0} tem {1} de energia e {2} de gold.",player.getName(),player.getEnergia(),player.gold);
            Console.Read();
        }
    }
}