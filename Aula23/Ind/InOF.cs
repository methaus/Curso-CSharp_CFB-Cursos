using System;

namespace Ind {
    class InOF {
        static void Main() {
            // DimensionalSearch
            // retorna o índice do array dado o primeiro valor encontrado
            int[,] array = {{0,0,0},{0,0,0},{0,0,0}};
            Random qlq = new Random();
            for (byte i = 0; i < 3; i++) {
                array[0,i] = qlq.Next(0,99); // Método "Next" para
                array[1,i] = qlq.Next(0,99);
                array[2,i] = qlq.Next(0,99);
            }
            Console.WriteLine("| {0,2} | {1,2} | {2,2} |",array[0,0],array[0,1],array[0,2]);
            Console.WriteLine("| {0,2} | {1,2} | {2,2} |",array[1,0],array[1,1],array[1,2]);
            Console.WriteLine("| {0,2} | {1,2} | {2,2} |",array[2,0],array[2,1],array[2,2]);
            Console.Write("Insira o valor para extrair o índice: ");
            int user = int.Parse(Console.ReadLine());
            int procurado = Array.IndexOf(array,user);
            Console.WriteLine("O valor procurado está no índice {0}",procurado);
            Console.WriteLine("Fim do programa...");
        }
    }
}