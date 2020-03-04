using System;

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
                _name = "FiveOneTwoEigth",
                Width = 50,
                Depth = 40,
                Stories = 4

            };
            Building BatmanBuilding = new Building("AT&T Building, Downtown Ave")
            {
                _name = "BatmanBuilding",
                Width = 300,
                Depth = 400,
                Stories = 13

            };
            Building NSS = new Building("301 Plus Park Blvd");
            NSS._name = "NSS";
            NSS.Width = 200;
            NSS.Depth = 100;
            NSS.Stories = 6;

            NSS.Construct();
            FiveOneTwoEigth.Construct();
            BatmanBuilding.Construct();
            NSS.Purchase("John Wark");
            FiveOneTwoEigth.Purchase("Johnny Bravo");
            BatmanBuilding.Purchase("Bruce Wayne");

            Nashville.addBuilding(NSS);
            Nashville.addBuilding(BatmanBuilding);
            Ellivhsan.addBuilding(FiveOneTwoEigth);

            Console.WriteLine($"{Nashville.Name} has the following buildings: ");
            foreach (Building building in Nashville.Buildings)
            {
                Console.WriteLine($"{building._name} located at: {building._address}");
            }

            Console.WriteLine($"{Ellivhsan.Name} has the following buildings: ");
            foreach (Building building in Ellivhsan.Buildings)
            {
                Console.WriteLine($"{building._name} located at: {building._address}");
            }

        }
    }
}
