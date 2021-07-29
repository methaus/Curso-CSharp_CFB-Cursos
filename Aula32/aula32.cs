using System;

namespace Aula32 {
    class Operador {
        public int valor1;
        public int valor2;
        public Operador(int valor1, int valor2) {
            //this relaciona à classe
            this.valor1 = valor1;
            this.valor2 = valor2;
        }
        public int soma() {
            return valor1 + valor2;
        }
    }
    class program {
        static void Main() {
            Operador soma = new Operador(1,2);
            Console.WriteLine(soma.soma());
            Console.Read();
        }
    }
}