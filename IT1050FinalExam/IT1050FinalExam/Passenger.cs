using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050FinalExam
{
    class Passenger
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Passenger(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string GetName()
        {
            return this.Name;
        }

        public double GetWeight()
        {
            return this.Weight;
        }
    }
}
