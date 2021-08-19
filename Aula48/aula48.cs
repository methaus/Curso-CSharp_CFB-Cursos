using System;

namespace Aula48 {
    class Calcular {
        public int Fatorial(int i) {
            int res;
            if (i <= 1) {
                res = 1;
            } else {
                res = i*Fatorial(i-1);
            }
            return res;
        }
    }
    class program {
        static void Main() {
            Calcular conta = new Calcular();
            Console.WriteLine(conta.Fatorial(5));
            Console.Read();
        }
    }
}