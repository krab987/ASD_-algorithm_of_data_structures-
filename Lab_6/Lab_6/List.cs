using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class List<T>
    {
        private const int DefaultCapacity = 4;

        internal T[] _items; // Do not rename (binary serialization)
        internal int _size; // Do not rename (binary serialization)
        private int _version; // Do not rename (binary serialization)

        public void Add(T item)
        {
            _version++;
            T[] array = _items;
            int size = _size;
            if ((uint)size < (uint)array.Length)
            {
                _size = size + 1;
                array[size] = item;
            }
            else
            {
                AddWithResize(item);
            }
        }
        private void AddWithResize(T item)
        {
            Debug.Assert(_size == _items.Length);
            int size = _size;
            Grow(size + 1);
            _size = size + 1;
            _items[size] = item;
        }
        private void Grow(int capacity)
        {
            Debug.Assert(_items.Length < capacity);

            int newcapacity = _items.Length == 0 ? DefaultCapacity : 2 * _items.Length;

            // Allow the list to grow to maximum possible capacity (~2G elements) before encountering overflow.
            // Note that this check works even when _items.Length overflowed thanks to the (uint) cast
            if ((uint)newcapacity > Array.MaxLength) newcapacity = Array.MaxLength;

            // If the computed capacity is still less than specified, set to the original argument.
            // Capacities exceeding Array.MaxLength will be surfaced as OutOfMemoryException by Array.Resize.
            if (newcapacity < capacity) newcapacity = capacity;

            Capacity = newcapacity;
        }

        public int Capacity
        {
            get => _items.Length;
            set
            {
                if (value < _size)
                {
                    ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value, ExceptionResource.ArgumentOutOfRange_SmallCapacity);
                }

                if (value != _items.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (_size > 0)
                        {
                            Array.Copy(_items, newItems, _size);
                        }
                        _items = newItems;
                    }
                    else
                    {
                        _items = s_emptyArray;
                    }
                }
            }
        }
    }
}
