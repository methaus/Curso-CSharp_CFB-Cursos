using System;

namespace Aula18 {
    class program {
        static void Main() {
            //byte[,] matriz;
            //byte[,] matriz = new byte[3,3];
            //byte[,] matriz = new byte[3,3] {{0,0,0},{0,0,0},{0,0,0}};
            byte[,] matriz = {{1,0,1},{0,1,0},{1,0,1}}; // a vírgula em "[,]" declara a bidimensionalidade
            /*
            |1 0 1|
            |0 1 0|
            |1 0 1|
            */
            Console.WriteLine("|{0} {1} {2}|\n|{3} {4} {5}|\n|{6} {7} {8}|",matriz[0,0],
            matriz[0,1],matriz[0,2],matriz[1,0],matriz[1,1],matriz[1,2],matriz[2,0],
            matriz[2,1],matriz[2,2]);
        }
    }
}

// as cadeias são as linhas, a quantidade de valores são as colunas
// posições = íncices(à partir do 0, ex:0,1,2) != tamanho = 1,2,3...