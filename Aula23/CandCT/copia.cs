using System;

namespace Aula23 {
    class copia {
        static void Main() {
            int[,] array0 = new int[3,3];
            int[,] array = new int[3,3];
            Random qlq = new Random(); // rng
            for (byte i = 0; i < 3; i++) { // rng
                array0[0,i] = qlq.Next(0,9); // rng
                array0[1,i] = qlq.Next(0,9); // rng
                array0[2,i] = qlq.Next(0,9); // rng
            }
            Array.Copy(array0,array,array0.Length); // método para imprimir um array, ou parte, em outro
            Console.WriteLine("| {0,2} | {1,2} | {2,2} |",array0[0,0],array0[0,1],array0[0,2]);
            Console.WriteLine("| {0,2} | {1,2} | {2,2} |",array0[1,0],array0[1,1],array0[1,2]);
            Console.WriteLine("| {0,2} | {1,2} | {2,2} |",array0[2,0],array0[2,1],array0[2,2]);
            Console.WriteLine("Quebra-texto...");
            Console.WriteLine("| {0,2} | {1,2} | {2,2} |",array[0,0],array[0,1],array[0,2]);
            Console.WriteLine("| {0,2} | {1,2} | {2,2} |",array[1,0],array[1,1],array[1,2]);
            Console.WriteLine("| {0,2} | {1,2} | {2,2} |",array[2,0],array[2,1],array[2,2]);
            Console.WriteLine("Fim do programa...");
        }
    }
}