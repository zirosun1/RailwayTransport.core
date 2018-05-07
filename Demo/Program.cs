using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RailwayTransport.core.Classes;
using RailwayTransport.core.Interfaces;
using RailwayTransport.core.Enums;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            train.Add(new Carriage()
            {
                ComfortClass = ComfortClass.common,
                NumberOfPassengers = 64,
                NumberOfBaggage = 64
            });
            train.Add(new Carriage()
            {
                ComfortClass = ComfortClass.reservedSeat,
                NumberOfPassengers = 48,
                NumberOfBaggage = 48
            });
            train.Add(new Carriage()
            {
                ComfortClass = ComfortClass.reservedSeat,
                NumberOfPassengers = 48,
                NumberOfBaggage = 48
            });
            train.Add(new Carriage()
            {
                ComfortClass = ComfortClass.coupe,
                NumberOfPassengers = 24,
                NumberOfBaggage = 24
            });
            train.Add(new Carriage()
            { 
                ComfortClass = ComfortClass.common,
                NumberOfPassengers = 64,
                NumberOfBaggage = 64
            });
            System.Console.WriteLine("Нетсортированный состав:\n");
            foreach (var i in train)
            {
                System.Console.WriteLine("{0}, {1}, {2}", i.ComfortClass, i.NumberOfPassengers, i.NumberOfBaggage);
            }
            train.SortByComfortClass();
            System.Console.WriteLine("\nОтсортированный состав:\n");
            foreach (var i in train)
            {
                System.Console.WriteLine("{0}, {1}, {2}", i.ComfortClass, i.NumberOfPassengers, i.NumberOfBaggage);
            }

            System.Console.WriteLine("\nЧисленность пассажиров в поезде:{0}",
                train.GetCommonNumberOfPassengers());
            System.Console.WriteLine("Численность багажа в поезде:{0}\n",
                train.GetCommonNumberOfBaggage());  
            System.Console.WriteLine("Вагоны с численостью пассажиров в диапазоне от 48 до 64:\n");
            foreach (var i in train.GetCarriages(48, 64))
            {
                System.Console.WriteLine("{0}, {1}, {2}", i.ComfortClass, i.NumberOfPassengers, i.NumberOfBaggage);
            }

            System.Console.ReadLine();
        }
    }
}
