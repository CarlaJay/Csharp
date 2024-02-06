using System;
using System.Security.Cryptography.X509Certificates;

namespace Activity_2
{
    public class Car
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }



        //main


        static void Main(string[] args)
        {

            List<Car> list = new List<Car>();

            while (true)
            {
                Console.WriteLine("Enter new data? [Y/N]");

                if (Console.ReadLine() == "N")
                {
                    break;
                }

                Car car1 = new Car();

                Console.WriteLine("Enter car Brand = ");
                car1.Brand = Console.ReadLine();

                Console.WriteLine("Enter car Color = ");
                car1.Color = Console.ReadLine();

                Console.WriteLine("Enter car Price = ");
                car1.Price = int.Parse(Console.ReadLine());


                list.Add(car1);
            }

            list.ForEach(x =>
            {
                Console.WriteLine(x.Brand);
                Console.WriteLine(x.Color);
                Console.WriteLine(x.Price);
                Console.WriteLine("===============");
            });

        }
    }
}