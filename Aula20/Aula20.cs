using System;

namespace Aula20 {
    class program {
        static void Main() {           
            int[] num = {0,0,0,0,0};
            int i = num.Length;
            while(i > 0) {
                int result = num[--i] = ++i;
                Console.WriteLine(result);
                --i;
            }
            Console.WriteLine("Fim do programa.");
        }
    }
}

 // loop while: enquanto "()" for verdadeiro
 // a ação do loop deve ser definida dentro da função "while{}"