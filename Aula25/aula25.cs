using System;

namespace Aula25 {
    class program {
        static void Main() {
            int num = 50;
            dobrar(ref num); // ref: referencial de mesma posição de memória
            Console.WriteLine(num);
        }
        static void dobrar(ref int valor) {
            valor*=2;
        }
    }
}