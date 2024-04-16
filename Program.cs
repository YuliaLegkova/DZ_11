using System;
using System.Linq.Expressions;
using System.Reflection;

namespace DZ_12
{
    internal class Program
    {
        static void Main(string[] args)

        {
                var dictionary = new OtusDictionary();

                dictionary.Add(1, "Один");
                dictionary.Add(2, "Два");
                dictionary.Add(3, "Три");
                dictionary.Add(4, "Четыре");
                dictionary.Add(5, "Пять");
                dictionary.Add(6, "Шесть");
                dictionary.Add(7, "Семь");
                dictionary.Add(8, "Восемь");
                dictionary.Add(9, "Девять");
                dictionary.Add(10, "Десять");
                dictionary.Add(11, "Одинадцать");
                dictionary.Add(12, "Двенадцать");
                dictionary.Add(13, "Тринадцать");
                dictionary.Add(14, "Четырнадцать");
                dictionary.Add(15, "Пятнадцать");
                dictionary.Add(16, "Шестнадцать");
                dictionary.Add(17, "Семнадцать");
                dictionary.Add(18, "Восемнадцать");
                dictionary.Add(19, "Девятнадцать");
                dictionary.Add(20, "Двадцать");
                dictionary.Add(21, null);
                dictionary.Add(22, "22");
                dictionary.Add(23, "23");
                dictionary.Add(24, "24");
                dictionary.Add(25, "25");
                dictionary.Add(26, "26");
                dictionary.Add(27, "27");
                dictionary.Add(28, "28");
                dictionary.Add(29, "29");
                dictionary.Add(30, "Тридцать");
                dictionary.Add(31, "Тридцать один");
                dictionary.Add(32, "Тридцать два");
                dictionary.Add(33, "Тридцать три");
                
                Console.WriteLine(dictionary.Get(3)); 
                Console.WriteLine(dictionary[2]);   
                dictionary[34] = "Тридцать четыре";
                dictionary[21] = "Двадцать один";

                Console.WriteLine(dictionary.Get(35));
                Console.WriteLine(dictionary.Get(36));

                dictionary.PrintAll();
         }
    }
}


