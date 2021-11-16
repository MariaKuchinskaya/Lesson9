using System;
using System.Collections.Generic;

namespace Lesson9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new MyCollection<IVehicle>();
            collection.AddToItems(new Car{name = "BMW"});
            collection.AddToItems(new Car{name = "Audi"});
            collection.AddToItems(new Boat{name = "Bloom"});
            collection.AddToItems(new Car{name = "Reno"});

            var result = collection.ReturnItemsByIndex(1);
            Console.WriteLine($"{result.name}");
            Console.WriteLine(collection.GetItemsCount());

           

        }
    }
}
