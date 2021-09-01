using System;
using System.Collections.Generic;

namespace Aula59 {
    class program {
        static void Main() {
            Queue<string> lista = new Queue<string>();
            lista.Enqueue("item1");
            lista.Enqueue("item2");
            lista.Enqueue("item3");
            lista.Enqueue("item4");
            foreach (string s in lista) {
                Console.WriteLine(s);
            }
            Console.WriteLine("Primeiro item: {0}", lista.Peek());
            for (int i = 0; i < 3; i++) {
                Console.WriteLine("Passando lista índice {0}: {1}",i,lista.Dequeue());
            }
            Console.WriteLine("Primeiro item: {0}, tamanho: {1}", lista.Peek(), lista.Count);
            Console.Read();
        }
    }
}