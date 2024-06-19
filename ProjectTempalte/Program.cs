using System.Collections;
using System.Text.RegularExpressions;

namespace ProjectTempalte
{
    internal class Program
    {
        static readonly string Prefix = @"..\..\..\";
        static void StackTask()
        {
            Console.WriteLine("Stack Task");
            int[] mas = {10, 20, 30};
            Stack<int> teststack = new Stack<int>(mas, 3);
            Console.WriteLine(teststack.Peek());
            teststack.Push(40);
            Console.WriteLine(teststack.Peek());
            teststack.Push(50);
            Console.WriteLine(teststack.Peek());
            teststack.Pop();
            Console.WriteLine(teststack.Peek());
            Console.WriteLine(teststack.IsEmpty());
            Console.WriteLine("-------");
        }
        static void DeepLookStackTask()
        {
            Console.WriteLine("DeepLookStack Task");
            int[] mas = { 10, 20, 30 };
            DeepLookStack<int> testdlt = new DeepLookStack<int>(mas, 3);
            Console.WriteLine(testdlt.Peek(1));
            Console.WriteLine(testdlt.Peek(2));
            Console.WriteLine(testdlt.Peek(3));
            testdlt.Push(40);
            Console.WriteLine(testdlt.Peek(4));
            Console.WriteLine("-------");
        }
        static void QueueTask()
        {
            Console.WriteLine("Queue Task");
            int[] mas = { 10, 20, 30 };
            Queue<int> testq = new Queue<int>(mas, 3);
            testq.Enqueue(40);
            Console.WriteLine(testq.Dequeue());
            Console.WriteLine(testq.Peek());
            Console.WriteLine(testq.Dequeue());
            Console.WriteLine(testq.Dequeue());
            Console.WriteLine(testq.Dequeue());
            Console.WriteLine(testq.IsEmpty());
            Console.WriteLine("-------");
        }
        // При работе с файлами, создавайте и наполняйте их сами. Но не забывайти использовать относительные пути
        static void StringTask()
        {
            Console.WriteLine("String Task");

            // Вывести:
            // * количество слов в тексте
            // * самое длинное слово
            // Можно считать, что слова разделены пробелами. Вместо явных циклов используйте LINQ.

            var path = Prefix + "Text.txt";
            List<string> list = new List<string>();
            list = Functions.ReadFromFile(path);
            Console.WriteLine($"Файл: {path}");
            Console.WriteLine($"Количество слов: {list.Count}");
            Console.WriteLine($"Самое длинное слово: {list.OrderByDescending(s => s.Length).First()}");
            Console.WriteLine("-------");
        }
        static void RegexTask()
        {
            Console.WriteLine("Regex Task");

            // TODO: написать Regex, который сумеет распознать email адрес.
            // Прочитать данные из файла и вывести количество email адресов.
            // Слов (а потенциально и адресов) в строке может быть несколько
            // Можно считать, что слова разделены пробелами

            var path = Prefix + "email.txt";
            Console.WriteLine($"Файл: {path}");
            Console.WriteLine($"Количество email адресов: {Regex.Matches(File.ReadAllText(path), "[\\w]+@[\\w]+.[\\w]{2,3}").Count}");
            Console.WriteLine("-------");
        }
        static void BinaryTask()
        {
            Console.WriteLine("Binary Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: реализовать функции чтения из бинароного файла и записи в него в Functions.cs.
            // Записать некоторое количество целых чисел в бинарный файл.
            // После прочитать этот же бинарный файл и вывести считанные значения на экран
            Console.WriteLine("-------");
        }
        static void DictionaryTask()
        {
            Console.WriteLine("Dictionary Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: создать Dictionary, где ключ - имя студента, а значение - лист его оценок по предметам за семестр.
            // Заполните словарь для 3-4 студентов.
            // Запросите у пользователя строку - имя студента, по которому он хочет узнать среднюю оценку.
            // Выведите результат. Вместо явных циклов используйте LINQ.
            Console.WriteLine("-------");
        }
        static void RecursionTask()
        {
            Console.WriteLine("Recursion Task");

            // TODO: рекурсивно описать функцию MinDigit(int n) (находится в Functions.cs),
            // которая находит наименьшую цифру в десятичной записи неотрицательного целого числа N.
            // Например, MinDigit(27316) = 1.

            int n = 27316;
            Console.WriteLine($"Минимальная цифра {n}: {Functions.MinDigit(n)}");
            Console.WriteLine("-------");
        }
        static void Main(string[] args)
        {
            StackTask();
            DeepLookStackTask();
            QueueTask();
            StringTask();
            RegexTask();
            BinaryTask();
            DictionaryTask();
            RecursionTask();
        }
    }
}
