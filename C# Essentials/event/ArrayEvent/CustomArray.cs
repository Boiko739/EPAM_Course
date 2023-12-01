using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ArrayEvent
{
    public class CustomArray<T> : IEnumerable<T>
    {
        /// <param name="sender">CustomArray parameter </param>
        /// <param name="e">ArrayEventArgs parameter</param>
        public delegate void ArrayHandler(object sender, ArrayEventArgs<T> e);

        /// <summary>
        /// Event that invokes when array element was changed 
        /// </summary>
        public event ArrayHandler OnChangeElement;

        /// <summary>
        /// Event that invokes when index of changed element equal to value 
        /// </summary>
        public event ArrayHandler OnChangeEqualElement;

        /// <summary>
        /// Should return first index of array
        /// </summary>
        public int First { get; private set; }

        /// <summary>
        /// Should return last index of array
        /// </summary>
        public int Last { get => First + Length - 1; }

        /// <summary>
        /// Should return length of array
        /// <exception cref="ArgumentException">Thrown when value was smaller than 0</exception>
        /// </summary>
        public int Length
        {
            get
            {
                return Array.Length;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value was smaller than 0.");
                }

                Array = new T[value];
            }
        }

        /// <summary>
        /// Should return array 
        /// </summary>
        public T[] Array
        {
            get; private set;
        }

        /// <summary>
        /// Constructor with first index and length
        /// </summary>
        /// <param name="first">First Index</param>
        /// <param name="length">Length</param>
        public CustomArray(int first, int length)
        {
            if (length <= 0)
            {
                throw new ArgumentException("Set property in Length should throw ArgumentException " +
                    "in case of length parameter smaller or equal 0  ");
            }
            First = first;
            Length = length;
            Array = new T[length];
        }

        /// <summary>
        /// Constructor with first index and collection  
        /// </summary>
        /// <param name="first">First Index</param>
        /// <param name="list">Collection</param>
        ///  <exception cref="ArgumentNullException">Thrown when list is null</exception>
        public CustomArray(int first, IEnumerable<T> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            else if (!list.Any())
            {
                throw new ArgumentException("CustomArray can't be created with list without elements ");
            }

            First = first;
            Length = list.Count();

            Array = list.ToArray();
        }

        /// <summary>
        /// Constructor with first index and params
        /// </summary>
        /// <param name="first">First Index</param>
        /// <param name="list">Params</param>
        ///  <exception cref="ArgumentNullException">Thrown when list is null</exception>
        /// <exception cref="ArgumentException">Thrown when list without elements </exception>
        public CustomArray(int first, params T[] list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }
            else if (list.Length == 0)
            {
                throw new ArgumentException("The list is without elements.");
            }

            First = first;
            Length = list.Count();
            Array = list;
        }

        /// <summary>
        /// Indexer with get and set  
        /// </summary>
        /// <param name="item">Int index</param>        
        /// <returns></returns>
        /// <exception cref="ArgumentException">Thrown when index out of array range</exception> 
        /// <exception cref="ArgumentNullException">Thrown in set  when value passed in indexer is null</exception>
        public T this[int item]
        {
            get
            {
                return item < First || item > Last
                    ? throw new ArgumentException("Index is out of the array range.")
                    : Array[item - First];
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                else if (item < First || item > Last)
                {
                    throw new ArgumentException("Index is out of the array range.");
                }

                int.TryParse(value.ToString(), out int val);

                string oldValue = Array[item - First]?.ToString();

                Array[item - First] = value;

                if (oldValue?.ToString() != value.ToString())
                {
                    OnChangeElement?.Invoke(this, new ArrayEventArgs<T>(item, "", value));
                    if (val == item)
                    {
                        OnChangeEqualElement?.Invoke(this, new ArrayEventArgs<T>(item, "", value));
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in Array)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Array.GetEnumerator();
        }
    }
}