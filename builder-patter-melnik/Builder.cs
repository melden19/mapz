using System;
using System.Collections.Generic;

namespace test
{
    interface ICityBuilder {
        void createComunications();
        void createBuildings();
        void createAsphalt();

        City getBuildedEntity();
    }

    abstract class DefaultCityBuilder : ICityBuilder {
        protected City city = new City();

        public void createComunications() {
            this.city.Connection = true;
            Console.WriteLine("Creating communications");
        }

        // implement in children classes
        public void createBuildings() {
            this.city.BuildingsList = this.getBuildings();
            Console.WriteLine("Creating buildings");
        }

        public void createAsphalt() {
            this.city.Asphalt = true;
            Console.WriteLine("Creating Asphalt");
        }

        public City getBuildedEntity() {
            return this.city;
        }

        public virtual List<byte> getBuildings() {
            return new List<byte>();
        }
    }

    class VillageBuilder : DefaultCityBuilder
    {
        public override List<byte> getBuildings() {
            return new List<byte>() {
                (byte)Buildings.Living,
                (byte)Buildings.Administrative
            };
        }
    }

    class OblCenterBuilder : DefaultCityBuilder
    {
        public override List<byte> getBuildings() {
            return new List<byte>() {
                (byte)Buildings.Living,
                (byte)Buildings.Administrative,
                (byte)Buildings.Entertainment,
            };
        }
    }

    class CapitalBuilder : DefaultCityBuilder
    {
        public override List<byte> getBuildings() {
            return new List<byte>() {
                (byte)Buildings.Living,
                (byte)Buildings.Administrative,
                (byte)Buildings.Entertainment,
                (byte)Buildings.Goverment,
            };
        }
    }
}
