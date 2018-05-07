using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayTransport.core.Interfaces
{
   public interface ICarriage
    {
        Guid Id { get;  }
        int NumberOfPassengers { get; set; }
        int NumberOfBaggage { get; set; }
        Enums.ComfortClass ComfortClass { get; set; }

    }
}
