using System;
using System.Collections.Generic;
using Transport;

namespace City
{
    interface ICityBuilder {
        void createComunications();
        void createBuildings();
        void createAsphalt();
        void createTransport();

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

        public void createTransport() {
                ITransportFactory domasticFactory = new DomesticTransportFactory(); 
                ITransportFactory importedFactory = new ImportedTransportFactory("Japanese");

                this.addTransport(domasticFactory.createTroleybus);
                this.addTransport(domasticFactory.createTram);
                this.addTransport(importedFactory.createMetro);
        }

        private void addTransport(Func<ITransport> create) {
            try {
                this.city.Transport.Add(create());
            } catch (Exception e) {
                // this.city.Transport.Add(e.Message);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
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
