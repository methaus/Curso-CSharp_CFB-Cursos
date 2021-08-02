using System;

namespace Aula33 {
    class Jogador {
        private string nome;
        private int energia;
        private bool vivo;
        public Jogador(string nome) {
            this.nome = nome;
            energia = 100;
            vivo = true;
        }
        public string getNome() {
            return nome;
        }
        public int getEnergia() {
            return energia;
        }
        public bool getVivo() {
            return vivo;
        }
        public void setNome(string nome) {
            this.nome = nome;
        }
        public void setEnergia(int energia) {
            if (energia <= 0) {
                this.energia = 0;
                vivo = false;
            } else if (energia > 100) {
                this.energia = 100;
            } else {
                this.energia = energia;
            }
        }
    }
    class program {
        static void Main() {
            Jogador j1 = new Jogador("Player_1");
            Console.WriteLine("Estado do {0}\nenergia: {1}\nvivo: {2}",j1.getNome(),j1.getEnergia(),j1.getVivo());
            Console.WriteLine("------------------------");
            Console.Write("Teste de alteração (nome): ");
            j1.setNome(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Estado do {0}\nenergia: {1}\nvivo: {2}",j1.getNome(),j1.getEnergia(),j1.getVivo());
            Console.Write("Teste de alteração (energia): ");
            j1.setEnergia(int.Parse(Console.ReadLine()));
            Console.WriteLine("------------------------");
            Console.WriteLine("Estado do {0}\nenergia: {1}\nvivo: {2}",j1.getNome(),j1.getEnergia(),j1.getVivo());
            Console.Read();
        }
    }
}