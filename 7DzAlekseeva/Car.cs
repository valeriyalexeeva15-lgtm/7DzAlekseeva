using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DzAlekseeva
{
    internal class Car
    {
        public string Model;
        public int Speed;
        public int MaxSpeed;

        public Car(string model, int maxSpeed)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            Speed = 0;
        }

        public void Accelerate(int delta)
        {
            Speed += delta;
            if (Speed > MaxSpeed)
            {
                Speed = MaxSpeed;
            }
        }

        public void Brake()
        {
            Speed = 0;
        }
    }
}