using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford","Explorer",2010 );

            Car car2 = new Car("Chevy", "Silverado", 2012);

            Car car3 = new Car("Toyta", "Camry", 2015);

            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(car3);
        }
    }
}
