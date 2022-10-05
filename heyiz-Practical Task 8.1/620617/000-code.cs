using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8._1
{
    public class MyStack<T>
    {
        private T[] array;
        public int Count { get; set; }

        public MyStack(int capacity)
        {
            array = new T[capacity];
            this.Count = 0;
        }

        public void Push(T val)
        {
            if (Count < array.Length)
            {
                array[Count++] = val;
            }
            else
            {
                throw new InvalidOperationException("The stack is out of capacity.");
            }
        }

        public T Pop()
        {
            if (Count > 0)
            {
                return array[--Count];
            }
            else
            {
                throw new InvalidOperationException("The stack is empty.");
            }
        }

        public T Find(Func<T, bool> criteria)
        {
            try
            {
                if (criteria == null) throw new ArgumentNullException("Criteria parameter was null");
                for (int i = Count - 1; i >= 0; i--)
                {
                    if (criteria(array[i])) return array[i];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            return default;
        }

        public T[] FindAll(Func<T, bool> criteria)
        {
            if(criteria == null)
            {
                throw new ArgumentNullException("null condotion");
            }
            else
            {
                List<T> save = new List<T>();
                try
                {
                    foreach( T a in array)
                    {
                        if (criteria(a) == true)
                        {
                            save.Add(a);
                        }
                    }
                    // checking the condition for list to have 0 element
                    if(save.Count ==0)
                    {
                        return null;
                    }
                    else
                    {
                        T[] savearray = save.ToArray();
                        return savearray;
                    }
                }
                catch
                {
                    return null;
                }
            }
        }

        public int RemoveAll(Func<T, bool> criteria)
        {
            try
            {

                if (criteria == null) throw new ArgumentNullException($"Criteria parameter was null!");

                int RemoveCount = 0;
                for (int i = Count - 1; i >= 0; i--)
                {
                    if (criteria(array[i])) RemoveCount++;
                }

                if (RemoveCount == 0) return 0;

                int arrayResize = Count - RemoveCount;
                T[] copiedArray = (T[])array.Clone();
                array = new T[arrayResize];

                int newIndex = arrayResize - 1;
                for (int i = copiedArray.Length - 1; i >= 0; i--)
                {
                    if (!criteria(copiedArray[i]))
                    {
                        array[newIndex--] = copiedArray[i];
                    }
                }
                return RemoveCount;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            return default;

        }
       
        public T Max()
        {
            Comparer<T> comparer = Comparer<T>.Default;
            T max = array[0];
            if(array.Length ==0)
            {
                return default(T);
            }
            for (int i=0; i<array.Length; i++)
            {
               if(comparer.Compare(array[i],max)>0)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public T Min()
        {
            Comparer<T> comparer = Comparer<T>.Default;
            T min = array[0];
            if (array.Length == 0)
            {
                return default(T);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (comparer.Compare(array[i], min) > 0)
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
