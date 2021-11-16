using System;

namespace Lesson9._1
{
    public class Boat: IVehicle
    {
        public string name { get; set; }

        public void Move()
        {
            Console.WriteLine("You move on a boat");
        }
    }
}