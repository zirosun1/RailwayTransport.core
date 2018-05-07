using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RailwayTransport.core.Interfaces;

namespace RailwayTransport.core.Classes
{
    class Train : ICollection<Interfaces.ICarriage>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        Guid Id { get; }

        public void Add(ICarriage item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(ICarriage item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(ICarriage[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ICarriage> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(ICarriage item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
