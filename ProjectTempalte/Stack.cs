using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTempalte
{
    public class Stack<T>
    {
        private T[] _values; // здесь будут храниться значения
        private int _size;   // количество значений, хранимых на стеке. но не фактических, а "валидных"
        private int _capacity;

        public int Size => _size;
        protected T[] Values => _values;

        // TODO:
        // Добавить параметр по умолчанию capacity
        // Иницилизировать поля класса в соответствии с принимаемыми аргументами
        public Stack(T[] values, int capacity)
        {
            _values = values;
            _capacity = capacity;
            _size = _values.Length;
        }

        // TODO:
        // Проверить, что ёмкость позволяет добавить элемент в массив
        // Если нет, изменить фактический размер массива и добавить элемент
        // Увеличить значение size
        public void Push(T value)
        {
            // Для изменения размера массива можно
            // либо создайте новый массив и перенесите в него элементы из старого,
            // либо воспользуйтесь функцией Array.Resize
            if (Size == _capacity)
            {
                _capacity *= 2;
                Array.Resize(ref _values, _capacity); 
                _values[_size] = value;
                _size++;
            }
            else
            {
                _values[_size] = value;
                _size++;
            }
        }

        // TODO:
        // Проверить, есть ли элементы в массиве values (обратитесь к переменной size)
        // Если нет, выдать ошибку
        // Если да, вернуть последний элемент и "удалить верхний элемент" (уменьшить значение size)
        public T Pop()
        {
            if (Size == 0)
                throw new Exception("Empty");
            else
            {
                _size--;
                return _values[_size];
            }
        }

        // TODO:
        // Аналогично предыдущему, но ничего не удаляем
        public T Peek()
        {
            if (Size == 0)
                throw new Exception("Empty");
            else
                return _values[_size - 1];
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }
    }
}
