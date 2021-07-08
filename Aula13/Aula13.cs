using System;

namespace Aula13 {
    class program {
        static void Main() {
            byte nota1, nota2;
            string result;
            float total;
            Console.WriteLine("Insira suas notas de 0 a 100:");
            Console.Write("Nota 1:");
            nota1 = Byte.Parse(Console.ReadLine());
            Console.Write("Nota 2:");
            nota2 = Byte.Parse(Console.ReadLine());
            total = (float)(nota1 + nota2) / 2;
            if (total >= 60) {
                if (total < 80) {
                    result = "Aprovado";
                } else {
                    result = "Aprovado com louvor";
                }                
            } else {
                if (total > 40) {
                    result = "Recuperação";
                } else {
                    result = "Reprovado";
                }
            }
            Console.WriteLine("Seu total é {0} e você está {1}.",total,result);
        }
    }
}