using System;

namespace Aula19 {
    class Aula19_1 {
        static void Main() {
            int[] num = {0,0,0,0,0};
            for(int i = num.Length - 1;i>0;i--) {
                int result = num[i] = i;
                Console.WriteLine(result);                
            }
            Console.WriteLine("Fim do programa.");            
        }
    }
}

// teste com a versão do professor, que não engloba a quantidade completa em índice