//  MELNIK DENIS
//  1PI-16b
//  LAB 1
//  VARIANT 13
//  BUILDER             - CityBuilder
//  ABSTRACT FACTORY    - Transport
//  SINGLETON           - Budget

using System;
using City;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Budget.getInstance().setLimit(5000);

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
            City.City city = buildDirector.Build();
            
            city.Info();
        }
    }
}