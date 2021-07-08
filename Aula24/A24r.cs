using System;

namespace Aula24 {
    class A24r {
        static void Main() {
            Console.WriteLine("CALCULADORA POR TECLADO, Números inteiros");
            Console.Write("Escolha o primeiro valor: ");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escolha o segundo valor: ");
            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o simbolo da operação desejada: ");
            char operação = Convert.ToChar(Console.ReadLine());
            int r = calculadora(v1,v2,operação);
            Console.WriteLine("{0} {1} {2} = {3}",v1,operação,v2,r);
            Console.WriteLine("Fim do programa...");
        }
        static int calculadora(int v1, int v2, char operação) { //Método agora retorna um valor
            int res = 0;
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
                    break;
                case 'x':
                case '*':
                    res = v1 * v2;
                    break;                
            }
            return res;      
        }
    }
}