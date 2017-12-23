using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
    {
       
        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;
        //Начнем с IEnumerator<T>. Специально укажем, что будем перечислять элементы от нашего типа T. 
        //Заведем переменную для фиксации текущего элемента и реализуем функции от этого интерфейса
        private int currentIndex;
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
        }


        //В параметризованном классе модифицируем метод добавления.Теперь, если у нас есть такая машина, то не добавляем новую. Было

        public static int operator + (ClassArray<T> p, T airvehicle)
        {
            var isAirVeh = airvehicle is UFO;
            if (p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }

            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (airvehicle.GetType() == p.places[i].GetType())
                {
                    if (isAirVeh)
                    {
                        if((airvehicle as UFO).Equals(p.places[i]))
                        {
                            throw new PlanetAlreadyHaveException();
                        }
                    }
                    else if ((airvehicle as AIRvehical).Equals(p.places[i]))
                    {
                        throw new PlanetAlreadyHaveException();
                    }
                }
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, airvehicle);
                return index;
            }
            p.places.Add(p.places.Count, airvehicle);
            return p.places.Count - 1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if(!p.CheckFreePlace(index))
            {
                T airvehical = p.places[index];
                p.places.Remove(index);
                return airvehical;
            }
            throw new ParkingIndexOutOfRangeException();
        }

        private bool CheckFreePlace (int index)
        {
            return !places.ContainsKey(index) ;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if(currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        //И последний шаг, интерфейс IComparable<ClassArray<T>>, который позволит сортировать элементы типа нашего параметризованного класса. 
        //Здесь сперва сравниваем по количеству объектов в словаре. Если оно равно, сравниваем сами объекты. Преимущество у объектов родительского класса.
        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for(int i = 0; i< this.places.Count; ++i)
                {
                    if (this.places[thisKeys[i]] is AIRvehical &&
                        other.places[otherKeys[i]] is UFO)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is UFO &&
                        other.places[otherKeys[i]] is AIRvehical)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is AIRvehical &&
                        other.places[otherKeys[i]] is AIRvehical)
                    {
                        return (this.places[thisKeys[i]] is AIRvehical)
                            .CompareTo(other.places[otherKeys[i]] is AIRvehical);
                    }
                    if (this.places[thisKeys[i]] is UFO &&
                       other.places[otherKeys[i]] is UFO)
                    {
                        return (this.places[thisKeys[i]] is UFO)
                            .CompareTo(other.places[otherKeys[i]] is UFO);
                    }
                }
            }
            return 0;
        }

        public T this [int ind]
        {
            get
            {
                if(places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }
    }
}
