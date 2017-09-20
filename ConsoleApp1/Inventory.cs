using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07Austin
{
    class Inventory<T> : IEnumerable<T>
    {
        T[] Products = new T[10];
        int count = 0;

        public void Add(T product)
        {
            Products[count] = product;
            count++;
            if (count == Products.Length -1)
            {
                Reallocate();
            }
        }

        public T Remove(int remove)
        {
            bool removed = false;
            T[] NewArray = new T[Products.Length];

            //Copies the old array into the new, minus the deletion
            for (int i = 0; i < count; i++)
            {

                if (removed == true)
                {
                    NewArray[i - 1] = Products[i];
                }
                if (i != remove && removed == false)
                {
                    NewArray[i] = Products[i];
                }
                else
                {
                    removed = true;
                }

            }
            count--;
            T returnItem = Products[remove];
            Products = NewArray;
            return returnItem;
        }

        public void Reallocate()
        {
            T[] NewArray = new T[Products.Length * 2];

            for (int i = 0; i < count; i++)
            {
                NewArray[i] = Products[i];
            }

            Products = NewArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return Products[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
