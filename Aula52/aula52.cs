using System;

namespace Aula52 {
    class program {
        static void Main() {
            int n1 = 10, n2 = 0;
            try {
                float res = n1/n2;
                Console.WriteLine("{0} / {1} = {2}",n1,n2,res);
            } catch(Exception e) {
                Console.WriteLine("Error: {0}",e);
            }
            Console.Read();
        }
    }
}