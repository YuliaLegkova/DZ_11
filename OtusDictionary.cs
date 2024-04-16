using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_12
{
    public class OtusDictionary
    {
        private const int InitialCapacity = 32;

        private (int key, string value)[] items;
        private int count;

        public OtusDictionary()
        {
            items = new (int, string)[InitialCapacity];
        }

        public void Add(int key, string value)
        {
            try
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                if (count == items.Length)
                {
                    Resize();
                }

                int index = key % items.Length;

                while (items[index].value != null)
                {

                    if (items[index].key == key)
                    {
                        throw new ArgumentException();
                    }

                    index = (index + 1) % items.Length;

                }

                items[index] = (key, value);
                count++;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Значение не может быть пустым");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Элемент с таким ключом уже содержится в словаре");
            }

        }
        private void Resize()
        {
            var newArray = new (int key, string value)[items.Length * 2];

            foreach (var (currentKey, currentValue) in items)
            {
                if (currentValue != null)
                {
                    int index = currentKey % newArray.Length;

                    while (newArray[index].value != null)
                    {
                        index = (index + 1) % newArray.Length;
                    }
                    newArray[index] = (currentKey, currentValue);
                }
            }

            items = newArray;
        }
        public string Get(int key)
        {
            try
            {
                int index = key % items.Length;

                while (items[index].value != null)
                {

                    if (items[index].key == key)
                    {
                        return items[index].value;
                    }

                    index = (index + 1) % items.Length;
                }

                throw new KeyNotFoundException();
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Ключ не был найден в словаре");
                return null;
            }
        }

        public string this[int key]
        {
            get => Get(key);
            set => Add(key, value);
        }
        public void PrintAll()
        {
            foreach (var (key, value) in items)
            {
                if (value != null)
                {
                    Console.WriteLine($"Key: {key}, Value: {value}");
                }
            }
        }
    }
}
