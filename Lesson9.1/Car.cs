using System;

namespace Lesson9._1
{
    public class Car: IVehicle
    {
        public string name { get; set; }

        public void Move()
        {
            Console.WriteLine("You move on a car");
        }
    }
}