using System;

namespace Aula19 {
    class program {
        static void Main() {
            int[] top5 = {0,0,0,0,0};
            Console.WriteLine("Prepare-se para o Top de Cinco Segundos:");
            for (int i = top5.Length; i > 0; i--) {
            int sprite = top5[--i] = ++i;
            Console.WriteLine(sprite);
            }
            Console.WriteLine("Fim do programa.");
        }
    }
}

// for ("condicionador do loop" ; "condição matenedora do loop" ; "ação do loop)