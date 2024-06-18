using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectTempalte
{
    // ВНИМАНИЕ! Предлагаемая здесь реализация не является лучшей в своем роде
    // и создана для ознакомления с принципом работы очереди
    public class Queue<T>
    {
        private T[] _values; // здесь будут храниться значения
        private int _head; // голова, индекс, указывает на начало очереди
        private int _tail; // хвост, индекс, указывает на последний элемент очереди
        private int _size; // количество элементов в массиве. но не фактических, а "валидных", между head и tail.
        private int _capacity;

        public int Size => _size;

        // TODO:
        // Добавить параметр по умолчанию capacity
        // Иницилизировать поля класса в соответствии с принимаемыми аргументами
        public Queue(T[] values, int capacity)
        {
            _values = values;
            _head = 0;
            _tail = values.Length - 1;
            _size = values.Length;
            _capacity = capacity;
        }

        private void FindOrCreateEmptySpace()
        {
            if (_head != 0) // Если есть свободное место справа слева
            {
                // TODO:
                // Воспользуйтесь функцией Array.Copy для переноса валидных элементов массива влево.
                // Откуда копируем - values
                // Индекс откуда начинать копировать - head
                // Куда копировать - values
                // Индекс куда начинать копировать - 0
                // Сколько копировать - size
                // Далее обновите значения tail и head
                Array.Copy(_values, _head, _values, 0, _size);
                _head = 0;
                _tail = _size - 1;


                // В итоге поменяли массив так, что все его валидные элементы находятся в его начале.
                // По сути просто сдвиг элементов влево.
                // Как итог, в конце массива освободилось место
                return;
            }

            // TODO:
            // Измененить размер массива, обновите tail и head
            _capacity *= 2;
            Array.Resize(ref _values, _capacity);
            _size = _tail - _head + 1;
            _head = 0;
            _tail = _size - 1;
        }

        // TODO:
        // Проверить, что мы можем добавить элемент в массив (проверьте значения tail и values.length)
        // Если нет, вызвать FindOrCreateEmptySpace
        // Добавить элемент и увеличить значение size и tail
        public void Enqueue(T value)
        {
            if (_tail == _values.Length - 1)
                FindOrCreateEmptySpace();
            _values[_size] = value;
            _size++;
            _tail++;
        }

        // TODO:
        // Если размер == 0, выдаем ошибку
        // Запоминаем первый (head) элемент в переменную
        // Если голова находится в конце массива, обнуляем (мы прошли весь массив слева направо, элементов больше нет).
        // Иначе увеличиваем (элементы еще есть)
        // Не забудьте уменьшить размер и вернуть элемент
        public T Dequeue()
        {
            return default(T); // Заглушка
        }

        // TODO:
        // Проверяем размер, выдаем ошибку при нулевом размере
        // Возвращаем элемент
        public T Peek()
        {
            return default(T); // Заглушка
        }

        public bool IsEmpty()
        {
            return true; // TODO: поменять
        }
    }
}
