using System;

namespace Aula3 {
    class Aula3 {
        static void Main(string[] args) {
            Console.WriteLine("Teste Aula 3.");
            byte var_pequena = 0; // recebe o valor de 1 bits
            int inteiro = 1; // recebe valor de 32 bits
            char letra = '0';
            float valor_real = 1.0f;
            string mot = "palavra0";
            var qualquer = true;
            Console.Write(var_pequena+" "+inteiro+"\n");
            Console.WriteLine(letra);
            Console.WriteLine(valor_real);
            Console.WriteLine(mot);
            Console.WriteLine(qualquer);
            var trocavar = mot = "mudei0";
            Console.WriteLine(trocavar);
            int num1=1, num2=1, conta=1; //pode definir a variável onde quiser, quanto menos linhas no código melhor!!!
            num1 = 2;
            num2 = 3;
            conta = num1 + num2;
            Console.Write("A resposta de "+num1+" mais "+num2+" é igual a "+conta);
        }
    }
}
// **** VARIÁVEIS LOCAIS AO MÉTODO MAIN ****
// Declaração de variavel: de proporção definida: "byte" que recebe valores de 0 a 255, sem sinal
// Declaração de variavel: inteira: "int"; 
// Declaração de variavel: real: "float"(necessita de ficheiro "f" no fim da variável); pode armazenar valores inteiros
// Armazenamento de caracteres: "char" que lê o código entre aspa: "char num = 'c'"
// "char": é uma variável primitiva = caracter, entre aspa ('); pode ser um número ex. '8'
// "string": conjunto de caracteres = cadeia de caracteres, entre aspas (") 
// "var" declarar variável sem especificar tipagem no título.
// Concatenar texto no Write: ("texto"+variável)
// Pula para a próxima linha em .Write = .Write("\n"); ("\r") = substitui a próxima linha
// Declaração multipra de variáveis