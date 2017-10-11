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
        private double distanceTraveled;

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

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }

        public Vehicle()
        {

        }

        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.distanceTraveled = 0.0d;   //not set as a parameter, hardcoded to zero.
        }

        public void Move()
        {
            //distanceTraveled = distancTraveled + movementSpeed;
            distanceTraveled += movementSpeed;
        }


    }
}
