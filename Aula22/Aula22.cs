using System;

namespace Aula22 {
    class program {
        static void Main() {
            int[] num = {0,0,0,0,0};
            byte contador = 5;
            foreach(int n in num){
                num[n] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Controle:");
            while(contador > 0){
                Console.WriteLine(num[--contador]);                
            }         
            Console.WriteLine("Fim do programa.");
        }
    }
}

// foreach substitui a variável atuante pela denominada na ação
// foreach lê automaticamente cada índice do array indicado pelo "in"
// para ler elementos de uma coleção
// com a instrução "Read" só responde com dois null ??????