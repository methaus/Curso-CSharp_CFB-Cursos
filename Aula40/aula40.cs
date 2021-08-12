using System;

namespace Aula40 {
    sealed class Base {}
    class Derivada:Base {}
    class program {
        static void Main() {
            Derivada derivada = new Derivada();
            Console.Read();
        }
    }
}

//sealed classes que não podem ser herdadas