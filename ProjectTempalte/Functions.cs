using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        List<int> list = new List<int>();
        using (var fs = File.Open(path, FileMode.Open))
        using (var br = new BinaryReader(fs))
        {
            var sz = br.BaseStream.Length / sizeof(int);
            for (var i = 0; i < sz; i++)
            {
                list.Add(br.ReadInt32());
            }
        }
        return list;
    }

    // TODO:
    // Функция должная записывать целые числа в бинарный файл
    public static void WriteIntsToBinaryFile(string path, List<int> data)
    {
        using (var fs = File.Create(path))
        using (var bw = new BinaryWriter(fs))
        {
            for (int i = 0; i < data.Count; i++)
                bw.Write(data[i]);
        }

    }

    public static int MinDigit(int n)
    {
        if (n < 10)
            return n;
        return Math.Min(n % 10, MinDigit(n / 10));
    }
}


