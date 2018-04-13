using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles;

        public int MaxCapacity { get; set; }
        public int Count { get; set; }
        public Garage(int maxCapacity)
        {
            MaxCapacity = maxCapacity;
            Count = 0;
            vehicles = new T[MaxCapacity];
        }

        public void Park(T input)
        {
            if (MaxCapacity > Count)
            {
                vehicles[Count] = input;
                Count += 1;
            }
           
            else
            {
                for (int i = 0; i < Count; i++)
                {
                    if (vehicles[i] == null)
                    {
                        vehicles[i] = input;
                    }
                    break;
                }
            }
         
            
        }

        
       
        public void UnPark(string regNumber)
        {
           
                for (int i = 0; i < Count; i++)
                {
                    if (vehicles[i].RegNumber == regNumber)
                    {
                    vehicles[i] = null;
                       
                    }

                }

        }
        

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return vehicles[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
