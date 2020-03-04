using System.Collections.Generic;

namespace charp_urban_planner
{
    public class City
    {
        public City(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int Founded { get; set; }
        public List<Building> Buildings = new List<Building>();

        //methods

        public void addBuilding(Building name)
        {
            Buildings.Add(name);
        }

    }
}