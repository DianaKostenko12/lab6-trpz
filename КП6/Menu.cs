using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using КП6.HelperClasses;
using КП6.Tasks;

namespace КП6
{
    public class Menu
    {
        Task1 task1 = new Task1();
        Task2 task2 = new Task2();
        Task3 task3 = new Task3();
        Task4 task4 = new Task4();

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введiть номер завдання (1-4) або 0 для виходу:");
                string input = Console.ReadLine();

                if (input == "0")
                {
                    break;
                }

                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            task1.Execute();
                            break;
                        case 2:
                            task2.Execute();
                            break;
                        case 3:
                            task3.Execute();
                            break;
                        case 4:
                            task4.ProcessString();
                            break;
                        default:
                            Console.WriteLine("Неправильний номер завдання. Спробуйте ще раз.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Введіть дійсний номер.");
                }
            }
        }
    }
}
