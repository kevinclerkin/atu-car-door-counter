using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDoorCounter
{
    public class Car
    {
        private readonly int _numberOfDoors = 2;

        public int NumberOfDoors
        {
            get { return _numberOfDoors; }
        }

        public bool GetNumberOfDoors()
        {
            return NumberOfDoors > 1 && NumberOfDoors < 5;
        }
    }
}
