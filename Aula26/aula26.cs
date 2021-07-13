using System;

namespace Aula26 {
    class program {
        static void Main() {
            int resto;
            Console.Write("Valor do dividendo: ");
            int dividendo = int.Parse(Console.ReadLine());
            Console.Write("Valor do divisor: ");
            int divisor = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} : {1} = {2}, resto {3}", dividendo, divisor, dividir(dividendo, divisor, out resto), resto);
            Console.Read();
        }

        static int dividir(int dividendo, int divisor, out int resto) {
            int quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }
    }
}