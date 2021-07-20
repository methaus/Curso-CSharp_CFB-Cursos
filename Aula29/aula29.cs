using System;

namespace Aula29 {
    class Construtor {
        public int energia;
        public bool vivo;
        public string nome;
        public Construtor(string parametro) {
            energia = 100;
            vivo = true;
            nome = parametro;
        }
        ~Construtor() {
            // destrutor
            Console.WriteLine("Objeto {0} foi destruido.",nome);
        }
    }

    class program {
        static void Main() {
            Construtor jogador1 = new Construtor("Jojador 1");
            Construtor jogador2 = new Construtor("Jojador 2");

            jogador2.energia = 0;
            jogador2.vivo = false;

            Console.WriteLine("{0} tem energia = {1} e vivo = {2}",jogador1.nome,jogador1.energia,jogador1.vivo);
            Console.WriteLine("{0} tem energia = {1} e vivo = {2}",jogador2.nome,jogador2.energia,jogador2.vivo);
            Console.Read();
        }
    }
}

/* 
C:\Users\Estudio3\Documents\GitHub\C# Arquives\Aula29>aula29
Jojador 1 tem energia = 100 e vivo = True
Jojador 2 tem energia = 0 e vivo = False

*Enter* - depois que os comandos terminam

Objeto Jojador 2 foi destruido.
Objeto Jojador 1 foi destruido.

C:\Users\Estudio3\Documents\GitHub\C# Arquives\Aula29>
*/