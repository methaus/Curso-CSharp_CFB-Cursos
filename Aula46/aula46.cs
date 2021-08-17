using System;

namespace Aula46 {
    class MobSpawn {
        static int numEnemies = 0;
        private string name;
        public MobSpawn(string name) {
            this.name = name;
        }
        public Enemy CreateEnemy() {
            numEnemies++;
            return new Enemy(numEnemies, name);
        }
        public void EnemiesInfo() {
            Console.WriteLine("Existem {0} inimigos.",numEnemies);
        }
    }
    class Enemy {
        public int id;
        public string areaOrigin;
        public Enemy(int id, string areaOrigin) {  
            this.id = id;
            this.areaOrigin = areaOrigin;
            Info();
        }
        public void Info() {
            Console.WriteLine("Inimigo id: {0}, area: {1} criado...",id,areaOrigin);
        }
    }
    class program {
        static void Main() {
            MobSpawn ermo = new MobSpawn("Ermo");
            MobSpawn castelo = new MobSpawn("Castelo");
            MobSpawn deserto = new MobSpawn("Deserto");

            ermo.CreateEnemy();
            ermo.CreateEnemy();
            ermo.CreateEnemy();

            castelo.CreateEnemy();

            deserto.CreateEnemy();
            deserto.CreateEnemy();

            ermo.EnemiesInfo();

            Console.Read();
        }
    }
}