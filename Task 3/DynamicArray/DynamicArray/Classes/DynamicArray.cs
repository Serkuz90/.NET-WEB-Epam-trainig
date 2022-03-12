using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray.Classes
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] _defoultArray;
        private int _capacity = 0;
        private int _index = -1;
        private int _length = 0;
        public DynamicArray()
        {
            _capacity = 8;
            _defoultArray = new T[_capacity];


        }

        public DynamicArray(int value)
        {
            if(value > 0)
            {
                _capacity = value;
                _defoultArray = new T[_capacity];
            }
            else throw new ArgumentOutOfRangeException();
           
        }

        public DynamicArray(IEnumerable<T> collection)
        {
            AddRange(collection);
        }

        public void AddRange(IEnumerable<T> collection)
        {
            int tempLength;
            tempLength = _length + collection.Count();
            if(tempLength >= _capacity)
            {
                _capacity = tempLength+2;

                T[] temp = _defoultArray;

                _defoultArray = new T[_capacity];

                Array.Copy(temp, _defoultArray, _length);
            }
            foreach(var collect in collection)
            {
                Add(collect);
            }
        }

        public T this[int index]
        {
            get 
            {
                if(index < _length && index >= 0)
                {
                    return _defoultArray[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
            set
            {
                if (index < _length && index >= 0)
                {
                    _defoultArray[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void Add(T item)
        {
            if(_length>= _capacity)
            {
                _capacity = _capacity * 2;
                T[] temp = _defoultArray;

                _defoultArray = new T[_capacity];

                Array.Copy(temp, _defoultArray, _length);
            }
            _defoultArray[_length++] = item;
        }

        public void Insert(int index, T item)
        {
            if(index < 0 || index > _capacity)
            {
                throw new ArgumentOutOfRangeException();
            }
            
            if (_length  < _capacity)
            {

                for (int i = _length; i > index; i--)
                {
                    _defoultArray[i] = _defoultArray[i-1];
                }
                _defoultArray[index] = item;
            }
            else
            {
                _capacity = _capacity * 2;

                T[] temp = _defoultArray;
                _defoultArray = new T[_capacity];
                Array.Copy(temp, _defoultArray, _length++);

                Insert(index, item);
            }
        }

        public bool Remove(T item)
        {
            if (item == null) throw new ArgumentNullException();
            int index = Array.IndexOf(_defoultArray, item, 0, _length);
            if (index < 0) return false;

            for (int i = index; i < _length - 1; i++)
            {
                _defoultArray[i] = _defoultArray[i + 1];
            }
            _length--;
            return true;
        }

        public int Capacity
        {
            get { return _capacity; }
        }
        public int Length
        {
            get { return _length; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            while (MoveNext() == true)
            {
                T current = Current;
                yield return current;
            }
            Reset();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _length;
        }
        public void Reset()
        {
            _index = -1;
        }

        public T Current
        {
            get
            {
                return _defoultArray[_index];
            }
        }
    }
}
