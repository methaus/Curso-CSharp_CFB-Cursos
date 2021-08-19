using System;

namespace Aula50 {
    delegate void Info();
    class Personagem {
        public static void Info() {
            Console.WriteLine("Info do Personagem...");
        }
    }
    class Jogador {
        public static void Info() {
            Console.WriteLine("Info do Jogador...");
        }
    }
    class program {
        static void Main() {
            Info saida = new Info(Personagem.Info);
            saida();
            saida = new Info(Jogador.Info);
            saida();
            Console.Read();
        }
    }
}