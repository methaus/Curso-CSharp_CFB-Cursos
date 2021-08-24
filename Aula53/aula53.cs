using System;

namespace Aula52 {
    class Area {
        public static int calcular(int x, int h, out int area) {
            if (x == 0 || h == 0) {
                throw new Exception("Valores dos lados não podem ser zero.");
            }
            area = x * h;
            return area;
        }
    }
    class program {
        static void Main() {
            int area = 0;
            try {
                Area.calcular(10, 0, out area);
                Console.WriteLine("A área é {0}",area);
            } catch(Exception e) {
                Console.WriteLine("ERRO: {0}",e);
            } finally {
                Console.WriteLine("Fim do calculo...");
            }
            Console.Read();
        }
    }
}