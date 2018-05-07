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
            train.SortByComfortClass();

            System.Console.WriteLine("Численность пассажиров в поезде:{0}",
                train.GetCommonNumberOfPassengers());
            System.Console.WriteLine("Численность багажа в поезде:{0}",
                train.GetCommonNumberOfBaggage());
            System.Console.ReadLine();
        }
    }
}
