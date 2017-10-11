using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_3_Polymorphism
{
    class Automobile : Vehicle    // it now inherits from the base class Vehicle
    {
        private int numberOfWheels;
        private float wheelSize;                   // looks only like three field variables, though it inherits all of the the Vehicle class field variables
        private int numberOfDoors;                  //has the field variables of Vehicle, though cannot be modified, because they are private

        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }

        public Automobile (int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryingCapacity, string color, double movementSpeed)
        {
            //these fields are in the Automobile Class
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            // these fields are in the Vehicle Class
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

        }

    }
}
