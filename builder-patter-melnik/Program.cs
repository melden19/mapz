//  MELNIK DENIS
//  1PI-16b
//  VARIANT 4
//  BUILDER PATTERN

using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input city type (village, oblcenter, capital):");
            string cityType = Console.ReadLine();
            Console.WriteLine();
            
            ICityBuilder cityBuilder;

            switch (cityType) {
                case "village":
                    cityBuilder = new VillageBuilder();
                    break;
                case "oblcenter":
                    cityBuilder = new OblCenterBuilder();
                    break;
                case "capital":
                    cityBuilder = new CapitalBuilder();
                    break;
                default:
                    throw new System.ArgumentException("City type can be only one of the following: [village, oblcenter, capital]");
            }

            BuildDirector buildDirector = new BuildDirector(cityBuilder);
            City city = buildDirector.Build();

            city.Info();
        }
    }
}