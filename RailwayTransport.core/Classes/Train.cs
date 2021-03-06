﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RailwayTransport.core.Interfaces;

namespace RailwayTransport.core.Classes
{
   public class Train : ICollection<Interfaces.ICarriage>
    {
        private ICollection<Interfaces.ICarriage> train = new List<Interfaces.ICarriage>();

        Guid Id { get; }


        public int Count => train.Count;

        public bool IsReadOnly => train.IsReadOnly;


        public void Add(ICarriage item)
        {
            train.Add(item);
        }

        public void Clear()
        {
            train.Clear();
        }

        public bool Contains(ICarriage item)
        {
           return train.Contains(item);
        }

        public void CopyTo(ICarriage[] array, int arrayIndex)
        {
            train.CopyTo(array, arrayIndex);
        }

        public IEnumerator<ICarriage> GetEnumerator()
        {
           return train.GetEnumerator();
        }

        public bool Remove(ICarriage item)
        {
            return train.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return train.GetEnumerator();
        }


        public void SortByComfortClass() //сортировка по классу комфортности
        {
            var newList = train.ToList();
            newList.Sort((ICarriage x, ICarriage y) =>
            {
               return x.ComfortClass.CompareTo(y.ComfortClass);
            });
            train = newList;
        }

        public int GetCommonNumberOfPassengers() //получить общее число пассажиров в поезде
        {
            int _commonNumber=0;
            foreach(var i in train)
            {
                _commonNumber += i.NumberOfPassengers;
            }
            return _commonNumber;
        }

        public int GetCommonNumberOfBaggage() //получить общее число багажа в поезде
        {
            int _commonNumber = 0;
            foreach (var i in train)
            {
                _commonNumber += i.NumberOfBaggage;
            }
            return _commonNumber;
        }

        public IEnumerable<ICarriage> GetCarriages(int startRange,int endRange)
        {
            foreach(var i in train)
            {
                if (i.NumberOfPassengers >= startRange && i.NumberOfPassengers <= endRange)
                    yield return i;
            }
        }
    }
}
