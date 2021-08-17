using System;

namespace Aula45 {
    struct Personagem {
        public string name;
        public string classe;
        public Personagem(string name, string classe) {
            this.name = name;
            this.classe = classe;
        }
        public void info() {
            Console.WriteLine("{0}, O {1}.",name,classe);
        }
    }
    class program {
        static void Main() {
            Personagem[] players = new Personagem[2];
            players[0].name = "Goliath";
            players[0].classe = "Guerreiro";
            players[0].info();

            players[1].name = "Argus";
            players[1].classe = "Paladino";
            players[1].info();

            Console.Read();
        }
    }
}