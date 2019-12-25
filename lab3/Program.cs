//  MELNIK DENIS
//  1PI-16b
//  LAB 2
//  VARIANT 13
//  COMMAND             - Hero skills
//  MEDIATOR            - Arena
//  OBSERVER            - Subscribe heroes to arena events (battle_start, battle_end, break)
//  STRATEGY            - Purchases ["Blood Points", "Coins"]
//  TEMPLATE METHOD     - Atack algorithm (Command(skill) execution, sprite move, prepering, choose target, )

namespace Game {
    class Program {
        static void Main(string[] args) {
            Arena arena = new Arena();

            SkillCommand bowShot = new BowShotSkillCommand();
            SkillCommand fireballShot = new FireballShotSkillCommand();

            Attack silentAttack = new SilentAttack();
            Attack loudAttack = new LoudAttack();

            Hero archer = new Hero("Archer", bowShot, silentAttack);
            Hero wizard = new Hero("Wizart", fireballShot, loudAttack);

            arena.registerHero(archer);
            arena.registerHero(wizard);

            arena.promote(GameEvent.START);

            wizard.useSkill(archer);
            wizard.useSkill(archer);
            wizard.useSkill(archer);
            wizard.useSkill(archer);
            wizard.useSkill(archer);
            wizard.attack(archer);
            wizard.attack(archer);
            wizard.attack(archer);
            wizard.attack(archer);
            wizard.attack(archer);
            wizard.attack(archer);
            wizard.attack(archer);

            arena.printParticipants();
            arena.promote(GameEvent.FINISH);
        }
    }
}