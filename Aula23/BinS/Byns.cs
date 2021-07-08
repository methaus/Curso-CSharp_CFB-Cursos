using System;

namespace Aula23 {
    class Byns {
        static void Main() {
            // retorna a posição do valor escolhido
            int[] array = {0,1,2,3,4};
            foreach (int i in array) {
                Console.WriteLine(array[i]);
            }
            int procurado = 3;
            int leitor = Array.BinarySearch(array,procurado);
            Console.WriteLine("O valor {0} está na posição {1}",procurado,leitor);            
            Console.WriteLine("Fim do programa.");
        }
    }
}

// "IndexOf" faz a mesma coisa, retornando o índice do primeiro valor encontrado, caso repetido
// "LastIndexOf" faz a mesma coisa, retornando o índice do último valor encontrado, caso repetido