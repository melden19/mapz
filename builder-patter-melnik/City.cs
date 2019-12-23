using System;
using System.Collections.Generic;

namespace test
{
    enum Buildings : byte {
        Living = 1,
        Entertainment = 2,
        Administrative = 3,
        Goverment = 4
    }

    class City {
        private List<byte> buildings;
        private bool asphalt = false;
        private bool connections = false;

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

        //  Sorry for this piece of code. Haven`t code with C# for 2 years :)
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
        }
    }
}
