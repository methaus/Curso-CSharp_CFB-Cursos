using System;

namespace Aula12 {
    class program {
        static void Main() {
            // exemplo de resposta "aprovado" e "reprovado"
            byte nota1, nota2, nota3, nota4;
            float total;
            nota1 = nota2 = nota3 = nota4 = 0;
            Console.WriteLine("Insira suas notas de 0 a 100:");
            Console.Write("Nota 1: ");
            nota1 = Byte.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            nota2 = Byte.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            nota3 = Byte.Parse(Console.ReadLine());
            Console.Write("Nota 4: ");
            nota4 = Byte.Parse(Console.ReadLine());
            Console.Write("Sua média aritemética: ");
            total = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine(total);
            string resposta = "Reprovado";
            if (total >= 60) { 
                resposta = "Aprovado";
            }
            Console.WriteLine("Você ésta {0}.",resposta);
        }
    }
}

// "if" acrescenta linha de excessão ao código, se cumprido o requisito entre parenteses, a linha if()"{}" é lida
// Senão o código segue sem alterações