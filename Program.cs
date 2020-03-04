using System;

namespace charp_urban_planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 50,
                Depth = 40,
                Stories = 4

            };
            Building BatmanBuilding = new Building("AT&T Building, Downtown Ave")
            {
                Width = 300,
                Depth = 400,
                Stories = 13

            };
            Building NSS = new Building("301 Plus Park Blvd");
            NSS.Width = 200;
            NSS.Depth = 100;
            NSS.Stories = 6;

            NSS.Construct();
            FiveOneTwoEigth.Construct();
            BatmanBuilding.Construct();
            NSS.Purchase("John Wark");
            FiveOneTwoEigth.Purchase("Johnny Bravo");
            BatmanBuilding.Purchase("Bruce Wayne");

            Console.WriteLine(NSS.Description);

        }
    }
}
