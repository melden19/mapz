using System;

namespace Game {
    abstract class Attack {
        public void perform(Hero source, Hero target) {
            this.prepareToAttack(source);
            this.battleCry();
            this.attack(source, target);
        }

        protected void prepareToAttack(Hero source) {
            Console.WriteLine($"{source.name} prepering for attack...");
        }

        protected void attack(Hero source, Hero target) {
            target.receiveAttack(source.getDamage());
        }

        protected abstract void battleCry();
    }

    class SilentAttack : Attack {
        protected override void battleCry() {
            Console.WriteLine("........");
        }
    }

    class LoudAttack : Attack {
        protected override void battleCry() {
            Console.WriteLine("AAAAAAAAA!");
        }
    }
}