using System;

namespace Aula23 {
    class copia {
        static void Main() {
            int[] array0 = {0,0,0,0,0};
            int[] array = {0,0,0,0,0,0};
            Random qlq = new Random(); // rng
            for (byte i = 0; i < 5; i++) { // rng
                array0[i] = qlq.Next(0,9); // rng
            }
            array0.CopyTo(array,1); // método para copiar um array para outro à partir de
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} |",array0[0],array0[1],array0[2],array0[3],array0[4]);            
            Console.WriteLine("Quebra-texto...");
            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} |",array[0],array[1],array[2],array[3],array[4],array[5]);     
            Console.WriteLine("Fim do programa...");
        }
    }
}
// apenas unidimensional
// copia o array inteiro a partir do ponto indicado