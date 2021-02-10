using System;
using System.Collections;
using System.Collections.Generic;
namespace Cwiczenia
{
    internal class Llista<T> : IEnumerable<T>, IEnumerable
    {
        private T[] array = new T[100];
        private int lenght = 0;

        public void Add(T args)
        {
            array[lenght++] = args;
        }
        public void Remove(T args)
        {
            bool found = false;
            int index = 0;
            foreach (T item in array)
            {
                if (!found && item.Equals(args))
                {
                    found = true;
                }
                if (found && index + 1 < lenght)
                {
                    array[index] = array[index + 1];
                }
                index++;
            }
            lenght--;
        }
        public int Count()
        {
            return lenght;
        }
        public void AddRange(T[] args)
        {
            foreach (T item in args)
            {
                Add(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < lenght; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
}
