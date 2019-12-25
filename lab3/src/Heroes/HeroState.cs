using System;

namespace Game {
    class HeroState {
        private Hero context;
        public int dmg;
        public int hp;
        public int mana;
        public bool fighting = false;
        public bool alive = true;

        public HeroState(Hero context, int hp, int mana, int dmg) {
            this.context = context;
            this.hp = hp;
            this.dmg = dmg;
            this.mana = mana;
        }

        public void injure(int dmg) {
            this.hp -= dmg;

            if (this.hp < 0) {
                Console.WriteLine($"{this.context.name} is DEAD!");
                this.alive = false;
            }
        }

        public void drain(int mana) {
            this.mana -= mana;
        }
    }
}