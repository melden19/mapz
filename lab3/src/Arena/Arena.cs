using System;
using System.Collections.Generic;
using System.Linq;

namespace Game {
    enum GameEvent {
        START,
        FINISH,
        BREAK
    }

    interface IArenaObserver {
        void receiveArenaEvent(GameEvent gameEvent);
    }

    class Arena {
        private List<Hero> heroes = new List<Hero>();

        public void registerHero(Hero hero) {
            this.heroes.Add(hero);
        }

        public void promote(GameEvent gameEvent) {
            this.notifyHeroes(gameEvent);
        }

        private void notifyHeroes(GameEvent gameEvent) {
            this.heroes.ForEach(hero => hero.receiveArenaEvent(gameEvent));
        }

        public void printParticipants() {
            List<string> remainHeroes = this.heroes
                .Where(hero => hero.isAlive())
                .Select(hero => hero.name).ToList();

            Console.WriteLine("Alive heroes in arena:");
            Console.WriteLine(String.Join(", ", remainHeroes));
        }
    }
}