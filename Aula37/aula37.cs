using System;

namespace Aula37 {
    class Base {
        public Base() {
            Console.WriteLine("Base");
        }
    }
    class Derivada1:Base {
        public Derivada1() {
            Console.WriteLine("Derivada1");
        }
    }
    class Derivada2:Derivada1 {
        public Derivada2() {
            Console.WriteLine("Derivada2");
        }
    }
    class program {
        static void Main() {
            Derivada2 classe = new Derivada2();
            Console.Read();
        }
    }
}