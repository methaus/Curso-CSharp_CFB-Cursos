using System;

namespace Aula23 {
    class sorte { // unidimensional
        static void Main() {
            int[] array = new int[3];
            Random rng = new Random();
            for (byte i = 0; i < 3;i++) {
                array[i] = rng.Next(0,9);
            }
            Console.WriteLine("| {0} | {1} | {2} |",array[0],array[1],array[2]);
            Array.Sort(array);
            Console.WriteLine("Em ordem crescente:");
            Console.WriteLine("| {0} | {1} | {2} |",array[0],array[1],array[2]);
            Array.Reverse(array);
            Console.WriteLine("Em ordem decrescente:");
            Console.WriteLine("| {0} | {1} | {2} |",array[0],array[1],array[2]);
            Console.WriteLine("Fim do programa...");
        }
    }
}

// Organiza os valores do array em forma crescente, decrescente é só usar o "Array.Reverse"