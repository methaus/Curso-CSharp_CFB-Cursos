using System;

namespace Aula4 {
    class Program {
        static int num0 = -1;
        static void Main() {
            int num = 0;
            Console.WriteLine(num0);
            Console.WriteLine(num);
        }
        public void Teste() {
            int num = 1;
            Console.WriteLine(num);
        }
    }
}
// Escopo de variáveis: ONDE ESTA VARIÁVEL E VISÍVEL: global, local-método:Main,Teste...
// Variáveis globais funcionam para todos os métodos, desde que em mesma condição ex. "static int" p/ "static void" 
// Variáveis locais estão contidas em métodos ex."num" p/Main,
// ex. "num" é uma variável local ao método "Main"