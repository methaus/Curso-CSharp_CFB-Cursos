using System;

namespace Aula17 {
    class program {
        static void Main() {
            //byte array0,array1,array2,array3;
            //byte[] array = new byte[4];
            //byte[] array = new byte[4] {0,0,0,0};
            byte[] array = {0,0,0,0}; 
            array[0] = 1;
            array[3] = 1;
            Console.WriteLine(array[0]+"\n"+array[1]+"\n"+array[2]+"\n"+array[3]);
        }
    }    
}

// Quatro opções dos mesmo
// Cria um módolo com valores múltiplos indexados, quantidade entre "[]" e índice a partir do "0"