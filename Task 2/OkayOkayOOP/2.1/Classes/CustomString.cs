using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkayOkayOOP.Classes
{
    public class CustomString
    {
        private char[] _value;
        public int Count => _value.Length;
        public CustomString(string str)
        {
            _value = str.ToCharArray();
        }

        public char this[int index]
        {
            //было решено отказаться от сетера для защиты приватности строки
            get { return _value[index]; }
        }


        public CustomString(char[] value)
        {
            _value = new char[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                _value[i] = value[i];
            }
        }

        public bool Contains(char value)
        {
            for (int i = 0; i < _value.Length; i++)
            {
                if (value == _value[i])
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(char symbol)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_value[i] == symbol)
                {
                    return i;
                }
            }
            return -1;
        }


        public char[] ToCharArray()
        {
            char[] value = new char[Count];
            for (int i = 0; i < Count; i++)
            {
                value[i] = _value[i];
            }
            return value;
        }

        public override string ToString() => new string(_value);

        public static bool operator ==(CustomString someString1, CustomString someString2)
        {
            if (someString1.Count == someString2.Count)
            {
                for (int i = 0; i < someString1.Count; i++)
                {
                    if (someString1._value[i] != someString2._value[i])
                    {
                        return false;
                    }
                }
            }else
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(CustomString someString1, CustomString someString2)
        {
            if (someString1.Count == someString2.Count)
            {
                for (int i = 0; i < someString1.Count; i++)
                {
                    if (someString1._value[i] == someString2._value[i])
                    {

                    }
                    else
                    {
                        return true;
                    }
                }
            }else
            {
                return true;
            }
            return false;
        }

        public static CustomString operator +(CustomString someString1, CustomString someString2)
        {
            int a = someString1.Count;
            int b = someString2.Count;
            int z = a + b;
            char[] arr = new char[z];
            for (int i = 0; i < a; i++)
            {
                arr[i] = someString1._value[i];
            }
            for (int i = 0; i < b; i++)
            {
                arr[i+a] = someString2._value[i];
            }
            
            return new CustomString(arr);
        }
    }
}
