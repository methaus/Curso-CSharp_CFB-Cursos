using System;

namespace Aula5 {
    class Program {
        static void Main() {
            int valor = 1; // "=" é operador de atribuição: "valor" é "0"
            int soma = (5 + 5) * 2; // operador matemático: C# não lê a prioridade das operações matemáticas 
            bool boleano = 1 > 1; // operador que retorna valor me verdadeiro ou falso
            bool menorq = 1 <= 1; // menor ou igual a "1"
            bool maiorq = 1 >= 1; // maior ou igual a "1"
            bool iguala = 1 != 1; // é diferente de "1"
            Console.WriteLine(valor);
            Console.WriteLine(soma);
            Console.WriteLine(boleano);
            Console.WriteLine(menorq);
            Console.WriteLine(maiorq);
            Console.WriteLine(iguala);
            valor+=2; // incrementador: forma resumida de "valor = valor + 1"
            // resumo também serve para "*" e "/" ex 10/=2: 5
            soma++; // incrementador resumido: "soma" + 1
            int divisao = 10;
            divisao/=2;
            Console.WriteLine(valor);
            Console.WriteLine(soma);
            Console.WriteLine(divisao);
            bool and = boleano & menorq;
            bool or = boleano | menorq;
            Console.WriteLine(and); // sendo verdadeiro e falso: AND retorna "False"
            Console.WriteLine(or); // sendo verdadeiro e falso: OR retorna "True"
        }
    }
}

// Operadores de atribuição e matemáticos
// Operadores relacionais
// operadores de incremento e decremento
// incremento serve para "+" "-" "/" "*"
// AND: & = E e OR: | = OU
// AND retorna "True" apenas se todas forem "True"
// OR retorna "False" apenas se todas foram "False"