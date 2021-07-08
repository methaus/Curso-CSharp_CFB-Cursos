using System;

namespace Aula23 {
    class Rever {
        static void Main() {
            byte[] array = {0,1,2,3,4};          
            foreach (byte i in array) {
                Console.Write(i);
            }
            Console.Write(" ");
            Array.Reverse(array);
            foreach (byte i in array) {
                Console.Write(i);
            }
            Console.Write("\n");
            Console.WriteLine("Fim do programa...");
        }
    }
}