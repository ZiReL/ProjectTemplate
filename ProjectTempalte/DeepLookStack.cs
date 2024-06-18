using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTempalte
{
    // TODO:
    // Это должен быть класс стека, у которого можно просмотреть не только верхний элемент, но и некоторые под ним.
    // Сначала реализуйте класс Stack, если вы этого еще не сделали. Используйте наследование.
    // Полностью копировать код или писать код, реализация которого уже есть в класс Stack, запрещено.
    class DeepLookStack<T> : Stack<T>
    {
        public DeepLookStack(T[] values, int capacity) : base(values, capacity)
        {
        }
        /// <summary>
        /// Параметр - порядковый номер элемента в стеке (1 - голова, самый верхний, 2 - второй элемент сверху и так далее...).
        /// </summary>
        /// <param name="shift"></param>
        /// <returns></returns>
        public T Peek(int shift)
        {
            if (shift > Size)
                throw new ArgumentOutOfRangeException("Out of Range");
            else
                return Values[Size - shift];
        }
    }
}
