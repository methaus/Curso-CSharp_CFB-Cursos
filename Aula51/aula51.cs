using System;

namespace Aula51 {
    class program {
        static void Main(string[] args) {
            if (args.Length < 1) {
                Console.WriteLine("Não houve argumentos passados...");
            } else {
                for (int i = 0; i < args.Length; i++) {
                    Console.WriteLine("Argumento {0}: {1}",i+1,args[i]);
                }
            }
            Console.Read();
        }
    }
}