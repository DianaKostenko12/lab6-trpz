using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using КП6.HelperClasses;

namespace КП6.Tasks
{
    public class Task2
    {
        HelperTask2 helperTask2 = new HelperTask2();
        public void Execute()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "iван", Surname = "Петренко", Group = "КН101" },
                new Student { Id = 2, Name = "Ольга", Surname = "Коваль", Group = "КН102" },
                new Student { Id = 3, Name = "Марiя", Surname = "Шевченко", Group = "КН101" }
            };

            string command;
            do
            {
                Console.WriteLine("\nВведiть команду (show_all, add, remove, search, clear, sort, sort_desc, exit):");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "show_all":
                        helperTask2.PrintAllStudents(students);
                        break;
                    case "add":
                        helperTask2.AddStudent(students);
                        break;
                    case "remove":
                        helperTask2.DeleteStudent(students);
                        break ;
                    case "search":
                        helperTask2.SearchStudent(students);
                        break;
                    case "clear":
                        helperTask2.ClearStudents(students);
                        break;
                    case "sort":
                        helperTask2.SortStudents(students);
                        break;
                    case "sort_desc":
                        helperTask2.SortStudentsDescending(students);
                        break;
                    case "exit":
                        Console.WriteLine("Вихiд з програми.");
                        break;
                    default:
                        Console.WriteLine("Невiдома команда. Спробуйте ще раз.");
                        break;
                }
            } while (command != "exit");
        }
    }
}
