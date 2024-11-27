using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using КП6.HelperClasses;

namespace КП6.Tasks
{
    public class Task3
    {
        HelperTask3 helperTask3 = new HelperTask3();
        public void Execute()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Apple");
            arrayList.Add("Banana");
            arrayList.Add("Cherry");
            arrayList.Add("Orange");

            SortedList sortedList = new SortedList();
            sortedList.Add("C", "Cucumber");
            sortedList.Add("A", "Apple");
            sortedList.Add("B", "Banana");

            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("One", 1);
            dictionary.Add("Two", 2);
            dictionary.Add("Three", 3);

            Console.WriteLine("Виберiть колекцiю (0 - ArrayList, 1 - SortedList, 2 - Stack, 3 - Dictionary):");
            if (Enum.TryParse<CollectionType>(Console.ReadLine(), out CollectionType selectedCollection))
            {
                switch (selectedCollection)
                {
                    case CollectionType.ArrayList:
                        helperTask3.ManageArrayList(arrayList);
                        break;
                    case CollectionType.SortedList:
                        helperTask3.ManageSortedList(sortedList);
                        break;
                    case CollectionType.Stack:
                        helperTask3.ManageStack(stack);
                        break;
                    case CollectionType.Dictionary:
                        helperTask3.ManageDictionary(dictionary);
                        break;
                    default:
                        Console.WriteLine("Невiрний вибiр.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Невірний ввід.");
            }

            Console.WriteLine("Натисніть будь-яку клавішу для повернення до меню...");
            Console.ReadKey();
        }
    }
}
