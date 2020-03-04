using System;

namespace charp_urban_planner
{
    public class Building
    {
        private string _desginer { get; set; }

        private DateTime _dateConstructed { get; set; }

        public string Address { get; set; }

        private string _owner { get; set; }

        public string Name { get; set; }

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        //Constructor
        public Building(string address)
        {
            Address = address;
        }
        // Methods
        public void Build()
        {
            _dateConstructed = DateTime.Now;

        }
        public void Purchase(string name)
        {
            _owner = name;
        }
        public string Description
        {
            get
            {
                return ($"{Address} Designed by:{_desginer} Date Constructed:{_dateConstructed} Owned by:{_owner} Volume:{Volume} ");
            }

        }
    }
}