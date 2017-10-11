using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_3_Polymorphism
{
    class Vehicle
    {
        private int seats;
        private int carryingCapacity;
        private string color;
        private double movementSpeed;
        private float gearRatio;
        private float engineSize;

        public int Seats
        {
            get { return this.seats; }
        }

        public int CarryingCapacity
        {
            get { return this.carryingCapacity; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }


        }

    }
}
