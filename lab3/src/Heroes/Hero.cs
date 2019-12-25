using System;

namespace Game {
    class Hero : IArenaObserver {
        public readonly string name;
        private readonly HeroState state;
        public readonly SkillCommand skillCommand;
        public readonly Attack attackTemplate;
        public readonly int bloodPoints;
        public readonly int coins;

        public Hero(string name, SkillCommand skillCommand, Attack attack,
                int dmg = 10, int hp = 100, int mana = 100) {

            this.name = name;
            this.state = new HeroState(this, hp, mana, dmg);
            this.skillCommand = skillCommand;
            this.attackTemplate = attack;
        }

        public void attack(Hero target) {
            if (target.isAlive()) {
                this.attackTemplate.perform(this, target);
            } else {
                Console.WriteLine($"{target.name} is already dead. Calm yourself...");
            }
        }

        public void useSkill(Hero target) {
            int diff = this.state.mana - this.skillCommand.manaCost;
            if (diff >= 0 ) {
                this.state.drain(this.skillCommand.manaCost);
                this.skillCommand.exec(this, target);
            } else {
                Console.WriteLine($"Can't use skill, {this.name} needs {Math.Abs(diff)} more mana");
            }
        }

        public void receiveAttack(int dmg) {
            this.state.injure(dmg);
        }

        public void receiveArenaEvent(GameEvent gameEvent) {
            switch(gameEvent) {
                case GameEvent.START:
                    this.state.fighting = true;
                    Console.WriteLine($"{this.name} has entered to arena");
                    break;
                case GameEvent.FINISH:
                    this.state.fighting = false;
                    Console.WriteLine($"{this.name} has left an arena");
                    break;
                default:
                    Console.WriteLine("Unrecognized arena event type");
                    break;
            }
        }

        public bool isAlive() {
            return this.state.alive;
        }

        public int getDamage() {
            return this.state.dmg;
        }
    }
}