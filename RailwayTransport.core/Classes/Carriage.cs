using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RailwayTransport.core.Enums;

namespace RailwayTransport.core.Classes
{
  public class Carriage : Interfaces.ICarriage
    {
        private Guid _Id;
        private int _NumberOfPassengers;
        private int _NumberOfBaggage;
        private ComfortClass _ComfortClass;

        public Guid Id
        {
            get { return _Id; }
        }
        
        public int NumberOfPassengers
        { get { return _NumberOfPassengers; }
          set { _NumberOfPassengers = value; }
        }
        public int NumberOfBaggage
        {
            get { return _NumberOfPassengers; }
            set { _NumberOfBaggage = value; }
        }
        public ComfortClass ComfortClass
        {
            get { return _ComfortClass; }
            set { _ComfortClass = value; }
        }
    }
}
