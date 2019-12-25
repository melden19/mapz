using System;

namespace Game {
    abstract class SkillCommand {
        public readonly string name;
        public readonly int dmg;
        public readonly int manaCost;

        public SkillCommand(string name, int dmg, int manaCost) {
            this.name = name;
            this.dmg = dmg;
            this.manaCost = manaCost;
        }

        public abstract void exec(Hero source, Hero target);
    }

    class BowShotSkillCommand : SkillCommand {  
        public BowShotSkillCommand() : base("Bow shot", 20, 10) {}

        public override void exec(Hero source, Hero target) {
            Console.WriteLine($"{source.name} making a bow shot in {target.name}");
            target.receiveAttack(this.dmg);
        }
    }
    
    class FireballShotSkillCommand : SkillCommand {  
        public FireballShotSkillCommand() : base("Fireball shot", 30, 40) {}

        public override void exec(Hero source, Hero target) {
            Console.WriteLine($"{source.name} making a fireball shot in {target.name}");
            target.receiveAttack(this.dmg);
        }
    }
}