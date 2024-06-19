using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class Functions
{
    // TODO:
    // Функция должна прочитать содержимое файла и привести полученные строки к нижнему регистру.
    // Также должны быть удалены знаки препинания
    public static List<string> ReadFromFile(string filePath)
    {
        var list = new List<string>();
        char[] delimiterChars = { ' ', '\n' };
        list = Regex.Replace(File.ReadAllText(filePath).ToLower(), "[!\"\',.:;?\r]", string.Empty).Split(delimiterChars).ToList();
        return list;
    }

    // TODO:
    // Функция должная считывать и возвращать прочитанные целые числа из бинарного файла
    public static List<int> ReadIntsFromBinaryFile(string path)
    {
        return new(); // Заглушка
    }

    // TODO:
    // Функция должная записывать целые числа в бинарный файл
    public static void WriteIntsToBinaryFile(string path, List<int> data)
    {
    }

    public static int MinDigit(int n)
    {
        if (n < 10)
            return n;
        return Math.Min(n % 10, MinDigit(n / 10));
    }
}


