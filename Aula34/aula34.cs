using System;

namespace Aula34 {
    class Personagem {
        public string nome; // se private, não pode ser acessada pela classe herdada;
        public int energia;
        public bool vivo;
    }
    class Jogador:Personagem {
        private string classe;
        public Jogador(string nome, string classe) {
            this.nome = nome;
            this.classe = classe;
            energia = 100;
            vivo = true;
        }
        public string getClasse() {
            return classe;
        }
    }
    class program {
        static void Main() {
            Jogador j1 = new Jogador("Player_1", "curandeiro");
            Console.WriteLine("Nome {0}, classe {1} e energia {2}",j1.nome,j1.getClasse(),j1.energia);
            Console.Read();
        }
    }
}