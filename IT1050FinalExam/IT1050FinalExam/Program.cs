using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            Elevator.AddOccupant(new Passenger("A1", 180), 0);
            Elevator.AddOccupant(new Passenger("A2", 220), 1);

        }
    }
}
