﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_3_Polymorphism
{
    class Boat : Vehicle
    {

        private double waterDrag;

        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }


        public override void Move()
        {
            distanceTraveled += movementSpeed * waterDrag;
        }

    }
}
