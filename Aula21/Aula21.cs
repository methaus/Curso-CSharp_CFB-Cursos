using System;

namespace Aula21 {
    class program {
        static void Main() {
            byte qlq = 0;
            do {
                Console.WriteLine(qlq);
                qlq+=2; // pode se definer se a ação acontece antes ou depois           
            } while(qlq<10);
            Console.WriteLine(qlq);
            Console.Write("Fim do programa.");
        }
    }
}

// do: obriga a leitura do código