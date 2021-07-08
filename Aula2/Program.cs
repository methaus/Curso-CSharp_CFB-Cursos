using System;

namespace Program {
    class local {
        static void Main(string[] args) {
            Console.WriteLine("Teste Aula2.");
            if(args.GetLength(0)>0) {
                Console.WriteLine(args.GetValue(1));
            }
        }
    }
}
