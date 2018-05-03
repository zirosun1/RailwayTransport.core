using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.core.Interfaces
{
    interface ICarriage
    {
        Guid Id { get;  }
        int NumberOfPassengers { get; }
        Enums.ComfortClass ComfortClass { get; set; }

    }
}
