using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_3_Polymorphism
{
    class Aircraft : Vehicle
    {
        private double altitude;   // doesn't make sense for other vehicles, so that's why we give aircraft it's own derived class.

        public Aircraft(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            this.altitude = 0.0d;  // starts on ground, so we are accounting for that. don't want to give user the chance to control this variable, so we hardcode it.

        }

        public override void Move()
        {
            altitude += 10000.0d;  //raises altitude
            base.Move(); // this already moves the vehicle forward, and given that aircrafts move forward too, it's still applicable - no need to rewrite it.
            // altitude could also be down here, the order doesn't matter, each way completely valid
        }

        public override string GetDistanceTraveled()
        {
            return "Altitude: " + altitude + " - " + base.GetDistanceTraveled();
        }
    }
}
