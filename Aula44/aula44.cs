using System;

namespace Aula44 {
    struct Status {
        private string name;
        private int str;
        private int dex;
        private int hp;
        private int wis;
        private int luc;
        public Status(string name, int str, int dex, int hp, int wis, int luc) {
            this.name = name;
            this.str = str;
            this.dex = dex;
            this.hp = 10 + hp * 2;
            this.wis = wis;
            this.luc = luc;
        }
        public void info() {
            Console.WriteLine("{0}\nfor: {1}\ndex: {2}\nhp: {3}\nint: {4}\nluc: {5}",name,str,dex,hp,wis,luc);
        }
    }
    class program {
        static void Main() {
            Status player1Status = new Status("Goliath", 4, 2, 3, 0, 1);
            player1Status.info();
            Console.Read();
        }
    }
}