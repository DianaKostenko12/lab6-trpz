using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП6.HelperClasses
{
    public class HelperTask3
    {
        public void ManageArrayList(ArrayList arrayList)
        {
            PrintCollection(arrayList);
            Console.WriteLine("Додайте значення до ArrayList (введiть 'exit' для виходу):");
            FillCollection(arrayList);
            Console.Clear();
            PrintCollection(arrayList);
        }

        public void ManageSortedList(SortedList sortedList)
        {
            PrintCollection(sortedList);
            Console.WriteLine("Додайте значення до SortedList (введiть 'exit' для виходу):");
            FillCollection(sortedList);
            Console.Clear();
            PrintCollection(sortedList);
        }

        public void ManageStack(Stack stack)
        {
            PrintCollection(stack);
            Console.WriteLine("Додайте значення до Stack (введiть 'exit' для виходу):");
            FillCollection(stack);
            Console.Clear();
            PrintCollection(stack);
        }

        public void ManageDictionary(Dictionary<string, int> dictionary)
        {
            PrintCollection(dictionary);
            Console.WriteLine("Додайте пару 'ключ-значення' до Dictionary (введiть 'exit' для виходу):");
            FillCollection(dictionary);
            Console.Clear();
            PrintCollection(dictionary);
        }

        public void FillCollection(ArrayList arrayList)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;
                arrayList.Add(input);
            }
        }

        public void FillCollection(SortedList sortedList)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;
                string key = input.Substring(0, 1);
                if (!sortedList.ContainsKey(key))
                {
                    sortedList.Add(key, input);
                }
                else
                {
                    Console.WriteLine($"Ключ '{key}' вже iснує. Спробуйте ще раз.");
                }
            }
        }

        public void FillCollection(Stack stack)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;
                stack.Push(input);
            }
        }

        public void FillCollection(Dictionary<string, int> dictionary)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;
                var parts = input.Split('-');
                if (parts.Length == 2 && int.TryParse(parts[1], out int value))
                {
                    if (!dictionary.ContainsKey(parts[0]))
                    {
                        dictionary.Add(parts[0], value);
                    }
                    else
                    {
                        Console.WriteLine($"Ключ '{parts[0]}' вже iснує. Спробуйте ще раз.");
                    }
                }
                else
                {
                    Console.WriteLine("Невiрний формат, спробуйте ще раз (ключ-значення).");
                }
            }
        }

        public void PrintCollection(ArrayList arrayList)
        {
            Console.WriteLine("ArrayList:");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintCollection(SortedList sortedList)
        {
            Console.WriteLine("SortedList:");
            foreach (DictionaryEntry entry in sortedList)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        public void PrintCollection(Stack stack)
        {
            Console.WriteLine("Stack:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public void PrintCollection(Dictionary<string, int> dictionary)
        {
            Console.WriteLine("Dictionary:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

    }
}


