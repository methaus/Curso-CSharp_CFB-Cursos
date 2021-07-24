using System;

namespace Aula31 {
    class Inimigo {
        public static bool alerta;
        public string nome = "Unknow";
        public Inimigo() {
            alerta = false;
        }
        public Inimigo(string nomeInimigo) {
            nome = nomeInimigo;
            alerta = false;
        }
        public void Info() {
            Console.WriteLine("Nome: {0}, alerta: {1}",nome,alerta);
            Console.WriteLine("----------------------------------");
        }
    }
    class program {
        static void Main() {
            Inimigo i1 = new Inimigo();
            Inimigo i2 = new Inimigo("Inimigo 2");
            Inimigo i3 = new Inimigo("Inimigo 3");

            i1.Info();
            i2.Info();
            i3.Info();

            Inimigo.alerta = true;

            i1.Info();
            i2.Info();
            i3.Info();

            Console.Read();
        }
    }
}