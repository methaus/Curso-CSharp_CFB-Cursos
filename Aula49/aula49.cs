using System;

namespace Aula49 {
    class Chars {
        static int numChars = 0;
        public Chars() {
            numChars++;
            Console.WriteLine("Char criado...");
        }
        public static void charsInfo() {
            Console.WriteLine("Char criados: {0}",numChars);
        }
    }
    class program {
        static void Main() {
            Chars.charsInfo();
            Chars c1 = new Chars();
            Chars.charsInfo();
            Console.Read();
        }
    }
}