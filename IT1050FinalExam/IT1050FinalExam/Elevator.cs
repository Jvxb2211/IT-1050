using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050FinalExam
{
    class Elevator
    {
        public double MaxWeight { get; set; }
        public Passenger[] Occupants { get; set; }

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double totalWeight = 0;

            for(int i = 0; i < Occupants.Length; i++)
            {
                totalWeight = Occupants[i].GetWeight() + totalWeight;
            }

            return totalWeight;
        }

        public bool IsOverMaxCapacity()
        {
            double CurrentWeight = GetCurrentWeight();
            return CurrentWeight > this.MaxWeight;
        }
    }
}
