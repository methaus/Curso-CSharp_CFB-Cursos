using System;

namespace Aula30 {
    class Jogador {
        public string nome;
        public int energia;
        public bool vivo;
        public Jogador() {
            // template
            nome = "Unknow";
            energia = 100;
            vivo = true;
        }
        public Jogador(string entrada0) {
            // edit name
            nome = entrada0;
            energia = 100;
            vivo = true;
        }
        public Jogador(string entrada0, int entrada1) {
            // edit name, energia
            nome = entrada0;
            energia = entrada1;
            vivo = true;
            if (energia < 1) {
                vivo = false;
            }
        }
        public void Info() {
            Console.WriteLine("Nome: {0,10}, energia: {1,10}, vivo: {2,10}",nome,energia,vivo);
        }
    }
    class program {
        static void Main() {
            Jogador j1 = new Jogador();
            Jogador j2 = new Jogador("Jogador 2");
            Jogador j3 = new Jogador("Jogador 3", 0);
            j1.Info();
            j2.Info();
            j3.Info();
            Console.Read();
        }
    }
}