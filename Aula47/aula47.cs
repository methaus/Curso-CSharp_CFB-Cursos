using System;

namespace Aula47 {
    class program {
        class Calculadora {
            public int somar(params int[] num) {
                int res = 0;
                for (int i = 0; i < num.Length; i++) {
                    res+=num[i];
                }
                Console.Write("resposta int: ");
                return res;
            }
            public double somar(params double[] num) {
                double res = 0f;
                for (int i = 0; i < num.Length; i++) {
                    res+=num[i];
                }
                Console.Write("resposta double: ");
                return res;
            }
        }
        static void Main() {
            Calculadora soma = new Calculadora();
            var res = soma.somar(1,1);
            Console.WriteLine(res);
            Console.Read();
        }
    }
}