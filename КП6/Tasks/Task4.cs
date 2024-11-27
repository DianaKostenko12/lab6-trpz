using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП6.Tasks
{
    public class Task4
    {
        public void ProcessString()
        {
            Console.WriteLine("Введiть рядок:");
            string word = Console.ReadLine();

            List<char> elements = new List<char>();
            List<int> numbersForDelete = new List<int>();

            for (int i = 0; i <= word.Length - 1; i++)
            {
                if (i == word.Length - 1)
                {
                    if(word[i] == word[i - 1])
                    {
                        elements.Add(word[i]);
                        numbersForDelete.Add(i);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    if (word[i] == word[i + 1] || (i > 0 && word[i] == word[i - 1]))
                    {
                        elements.Add(word[i]);
                        numbersForDelete.Add(i);
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            List<string> grouped = new List<string>();
            if (elements.Count > 0)
            {
                grouped = elements.Aggregate(new List<string>(), (acc, c) =>
                {
                    if (acc.Count == 0 || acc.Last().Last() != c)
                    {
                        acc.Add(c.ToString());
                    }
                    else
                    {
                        acc[acc.Count - 1] += c;
                    }
                    return acc;
                });

                Console.WriteLine("Групи повторюваних символiв:");
                foreach (var group in grouped)
                {
                    Console.WriteLine(group + $" (Кількість: {group.Length})");
                }
            }

            string resultString = new string(word
                                            .Where((c, index) => !numbersForDelete.Contains(index))
                                            .ToArray());

            Console.WriteLine($"Рядок пiсля вилучення повторень: {resultString}");

            Console.WriteLine("Натисніть будь-яку клавішу для повернення до меню...");
            Console.ReadKey();
        }
    }
}
