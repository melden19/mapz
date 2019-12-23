using System;
using System.Collections.Generic;
using System.Linq;
using Transport;

namespace City
{
    enum Buildings : byte {
        Living = 1,
        Entertainment = 2,
        Administrative = 3,
        Goverment = 4
    }

    class City {
        private List<byte> buildings;
        private List<ITransport> transport = new List<ITransport>();
        private bool asphalt;
        private bool connections;

       public bool Asphalt
        {
            get {
                return asphalt;
            }
            set {
                asphalt = value;
            }
        }
       public bool Connection
        {
            get {
                return connections;
            }
            set {
                connections = value;
            }
        }
       public List<byte> BuildingsList
        {
            get {
                return buildings;
            }
            set {
                buildings = value;
            }
        }
       public List<ITransport> Transport
        {
            get {
                return transport;
            }
            set {
                transport = value;
            }
        }

        public void Info() {
            List<string> finalList = new List<string>();
            this.buildings.ForEach(delegate(byte building) {

                switch (building) {
                    case (byte) Buildings.Administrative:
                        finalList.Add("Administractive");
                        break;
                    case (byte) Buildings.Entertainment:
                        finalList.Add("Entertainment");
                        break;
                    case (byte) Buildings.Goverment:
                        finalList.Add("Goverment");
                        break;
                    case (byte) Buildings.Living:
                        finalList.Add("Living");
                        break;
                }
            });

            Console.WriteLine("Available buldings: ");
            finalList.ForEach(Console.WriteLine);
            Console.WriteLine("----------------------");
            Console.WriteLine("Alphalt: " + this.asphalt);
            Console.WriteLine("----------------------");
            Console.WriteLine("Connections: " + this.connections);
            Console.WriteLine("----------------------");

            Console.WriteLine("Available transport: ");
            transport
                .Select(t => t.ToString())
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
