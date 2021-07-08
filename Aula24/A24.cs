using System;

namespace Aula24 {
    class A24 {
        static void Main() {
            Console.WriteLine("CALCULADORA POR TECLADO");
            Console.Write("Escolha o primeiro valor: ");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escolha o segundo valor: ");
            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o simbolo da operação desejada: ");
            char operação = Convert.ToChar(Console.ReadLine());
            calculadora(v1,v2,operação);
            Console.WriteLine("Fim do programa...");
        }
        static void calculadora(int v1, int v2, char operação) { //Método é um bloco de instrução que recebe valores
            int res = 0;
            int resto = 0;
            bool gat = true;       
            switch (operação) {
                case '+':
                    res = v1 + v2;
                    break;
                case '-':
                    res = v1 - v2;
                    break;
                case '/':
                case ':':
                    res = v1 / v2;
                    resto = v1 % v2;
                    break;
                case 'x':
                case '*':
                    res = v1 * v2;
                    break;
                default:
                    gat = false;
                    break;
            }
            if (gat == false) {
                Console.WriteLine("Operação inválida.");
            } else {
                Console.WriteLine("{0} {1} {2} = {3}",v1,operação,v2,res);
                if (resto != 0) {
                Console.WriteLine("resto = {0}",resto);
                }
            }      
        }
    }
}