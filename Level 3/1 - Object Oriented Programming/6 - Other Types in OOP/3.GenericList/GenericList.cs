namespace _3.Generic_List
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    [Version(2.11)]
    public class GenericList<T> : IEnumerable<T> where T : IComparable<T>
    {
        const int DefaultCapacity = 16;

        private T[] elements = new T[DefaultCapacity];
        private int count = 0;

        public int Lenght
        {
            get { return this.elements.Length; }
        }

        public T this[int index]
        {
            get
            {
                if (!IsInRange(index))
                {
                    throw new ArgumentOutOfRangeException("The index number is out of range!");
                }
                return this.elements[index];
            }
            set
            {
                if (!IsInRange(index))
                {
                    throw new ArgumentOutOfRangeException("The index number is out of range!");
                }
                this.elements[index] = value;
            }
        }

        public void Add(T newElement)
        {
            if (this.count == this.Lenght)
            {
                T[] newValues = new T[this.Lenght * 2];
                Array.Copy(this.elements, newValues,this.Lenght);
                this.elements = newValues;
            }
            this.elements[this.count] = newElement;
            count++;
        }

        public void Remove(int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new ArgumentOutOfRangeException("The number you've tried to remove doesn't exist.");
            }
            T[] newValues = new T[this.Lenght];
            Array.Copy(this.elements, newValues,index);
            Array.Copy(this.elements, index + 1, newValues, index, this.Lenght - index-1);
            this.elements = newValues;
            this.count--;
        }
        public void Insert(T element, int index)
        {
            if (index < 0 || index > this.count)
            {
                throw new ArgumentOutOfRangeException("The number you've tried to insert is outside of the range.");
            }

            T[] newValues = new T[this.Lenght];
            if (this.count == this.Lenght)
            {
                newValues = new T[this.Lenght * 2];
            }
            Array.Copy(this.elements, newValues, index);
            newValues[index] = element;
            Array.Copy(this.elements, index, newValues, index + 1, this.Lenght - index - 1);
            this.elements = newValues;
            this.count++;
        }

        public int Find(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (elements[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (elements[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }


        public void Clear()
        {
            this.elements = new T[DefaultCapacity];
            this.count = 0;
        }

        public T Min()
        {
            T min = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(min) <= 0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.elements[0];
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = this.elements[i];
                }
            }
            return max;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.count ; i++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < this.count; i++)
            {
                result += elements[i] + ", ";
                if (i == this.count - 1)
                {
                    result = result.Substring(0, result.Length - 2);
                }
            }
            return result;
        }


        private bool IsInRange(int index)
        {
            if (index > 0 && index < this.count)
            {
                return true;
            }
            return false;
        }

    }
}