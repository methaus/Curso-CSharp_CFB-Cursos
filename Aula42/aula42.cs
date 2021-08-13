using System;

namespace Aul42 {
    class Personagem {
        public string[] status = new string[6] {"str","dex","hp","sta","int","luc"};
        public string this[int i] {
            get {
                return status[i];
            }
            set {
                status[i] = value;
            }
        }
        public Personagem() {}
        public void infoStatus() {
            Console.Write("Status: ");
            for (int i = 0; i < status.Length; i++) {
                Console.Write(" {0}",this[i]);
            }
        }
    }
    class program {
        static void Main() {
            Personagem player = new Personagem();
            player.infoStatus();
            Console.Read();
        }
    }
}