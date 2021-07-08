using System;

namespace Aula8 {
    class program {
        static void Main() {
            // Teste com soma padrão
            int valor1, valor2, resultado;
            string nome;
            Console.Write("Insira uma palavra para o teste: ");
            nome = Console.ReadLine();
            Console.WriteLine("A palavra digitada foi: {0",nome);
            Console.Write("Digite um valor inteiro para soma: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Agora digite o outro valor: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            resultado = valor1 + valor2;
            Console.WriteLine("A soma de {0} e {1} é igual a {2}",valor1,valor2,resultado);
        }
    }
}

//  "Int32.Parse" e "Int32.TryParse" só podem converter strings. "Convert.ToInt32" pode trabalhar com qualquer classe