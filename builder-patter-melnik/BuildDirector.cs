using System;

namespace test
{
    class BuildDirector
    {
        private ICityBuilder builder;
        
        public BuildDirector(ICityBuilder builder) {
            this.builder = builder;
        }

        public City Build() {
            this.builder.createAsphalt();
            this.builder.createBuildings();
            this.builder.createComunications();

            Console.WriteLine("Finish building city!\n");

            return this.builder.getBuildedEntity();
        }
    }
}
