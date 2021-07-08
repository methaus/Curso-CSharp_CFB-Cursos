using System;

namespace Val {
    class GV {
        static void Main() {
            // retornar um valor à partir de um índice
            // método object, precisa de cast
            int[,] array = {{1,2,3},{4,5,6}};
            int leitor = Convert.ToInt32(array.GetValue(1,1));
            Console.WriteLine(leitor);
            Console.WriteLine("Fim do programa...");
        }
    }
}