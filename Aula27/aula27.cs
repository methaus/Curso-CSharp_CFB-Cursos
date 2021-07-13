using System;

namespace Aula27 {
    class program {
        static void Main() {
            Console.WriteLine("As somas são: {0}", somatoria(1,1,2));
        }

        static int somatoria (params int[] num) {
            int somas = 0;
            if (num.Length <= 1) {
                Console.WriteLine("Valores insuficientes para somatório.");
            } else for (int i = 0; i < num.Length; i++) {
                somas+=num[i];
            }
            return somas;
        }
    }
}