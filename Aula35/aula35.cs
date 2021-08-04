using System;

namespace Aula34 {
    class NPC {
        public string nome;
        public int energia;
        public bool vivo;
        public NPC(string nome, int energia) {
            this.nome = nome;
            this.energia = energia;
            vivo = setEstado(energia);
        }
        private bool setEstado(int energia) {
            return (energia > 0? vivo = true: vivo = false); // intrução apenas no return
        }
        public void setEnergia(int energia) {
            this.energia = energia;
            vivo = setEstado(energia);
        }
    }
    class Personagem:NPC {
        public string classe;
        public Personagem(string nome, string classe, int energia):base(nome, energia) {
            this.classe = classe;
        }
    }
    class Jogador:Personagem {
        public int gold;
        public Jogador(string nome, string classe, int energia, int gold):base(nome, classe, energia) {
            this.gold = gold;
        }
        public void setGold(int gold) {
            this.gold = gold;
        }
    }
    class program {
        static void Main() {
            Jogador j1 = new Jogador("Player_1", "Curandeiro", 100, 0);
            j1.setEnergia(1);
            j1.setGold(300);
            Console.WriteLine("Nome...: {0}\nClasse.: {1}\nEnergia: {2}\nVivo...: {3}\nGold...: {4}",j1.nome,j1.classe,j1.energia,j1.vivo,j1.gold);
            Console.Read();
        }
    }
}