using System;

namespace Bound {
    class GLB {
        static void Main() {
            int[,] array = {{0,0,0},{0,0,0}};            
            int result0 = array.GetUpperBound(0)+1; // imprime maior índice daquela matriz  
            int result1 = array.GetUpperBound(1)+1;          
            Console.WriteLine("Linhas: {0}", result0);
            Console.WriteLine("Colunas: {0}", result1);            
            Console.WriteLine("Fim do programa...");
        }
    }
}
// retorna o maior índice da matriz
// bidimensional e indicado pelo índice entre parenteses "()" para 0 = linhas e para 1 = colunas