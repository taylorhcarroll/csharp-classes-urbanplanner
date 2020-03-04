using System;
using System.Collections.Generic;


namespace charp_urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Nashville = new City("Nashville")
            {
                Mayor = "McCheese",
                Founded = 1879
            };
            City Ellivhsan = new City("Ellivhsan")
            {
                Mayor = "Grimmace",
                Founded = 2020
            };
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Name = "FiveOneTwoEigth",
                Width = 50,
                Depth = 40,
                Stories = 4

            };
            Building BatmanBuilding = new Building("AT&T Building, Downtown Ave")
            {
                Name = "BatmanBuilding",
                Width = 300,
                Depth = 400,
                Stories = 13

            };
            Building NSS = new Building("301 Plus Park Blvd");
            NSS.Name = "NSS";
            NSS.Width = 200;
            NSS.Depth = 100;
            NSS.Stories = 6;

            NSS.Build();
            FiveOneTwoEigth.Build();
            BatmanBuilding.Build();
            NSS.Purchase("John Wark");
            FiveOneTwoEigth.Purchase("Johnny Bravo");
            BatmanBuilding.Purchase("Bruce Wayne");

            Nashville.addBuilding(NSS);
            Nashville.addBuilding(BatmanBuilding);
            Ellivhsan.addBuilding(FiveOneTwoEigth);

            List<City> cities = new List<City>()
             {
                Nashville,
                Ellivhsan
            };

            foreach (City city in cities)
            {
                Console.WriteLine($"{city.Name} has the following buildings: ");
                foreach (Building building in city.Buildings)
                {
                    Console.WriteLine($"{building.Name} located at: {building.Address}");
                }
            }
        }
    }
}
