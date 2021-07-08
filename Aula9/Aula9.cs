using System;

namespace Aula9 {
    class program {
        static void Main() {
            int num = 10;
            Console.WriteLine(num);
            int result = num << 02; // "<<" significa multiplicar por 2^x - sendo "x" o número indicado na operação ex:02
            Console.WriteLine(result);
            int half = result >> 1; // ">>" significa multiplicar por 2^-x - sendo "x" o número indicado na operação 
            Console.WriteLine(half);
        }
    }
}

// Operações para dobrar e dividir pela metade