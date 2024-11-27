using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КП6.HelperClasses
{
    public class HelperTask2
    {
        public void PrintAllStudents(List<Student> students)
        {
            if (students.Count > 0)
            {
                Console.WriteLine("Всi студенти:");
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.Surname} {student.Name} {student.Group}");
                }
            }
            else
            {
                Console.WriteLine("Список студентiв порожнiй.");
            }
        }
        public void AddStudent(List<Student> students)
        {
            Student student = new Student();
            Console.WriteLine("Введiть id студента:");
            student.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть iм'я студента:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Введiть прiзвище студента:");
            student.Surname = Console.ReadLine();
            Console.WriteLine("Введiть групу студента:");
            student.Group = Console.ReadLine();

            students.Add(student);
            Console.WriteLine("Студента додано.");
        }

        public void ClearStudents(List<Student> students)
        {
            students.Clear();
            Console.WriteLine("Колекцiя очищена.");
        }

        public void DeleteStudent(List<Student> students)
        {
            foreach (Student student in students)
                Console.WriteLine($"{student.Surname} {student.Name} {student.Group}");

            Console.WriteLine("Оберiть студента, якого хочете видалити:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть ID студента для видалення: ");
            int id = int.Parse(Console.ReadLine());

            var studentToRemove = students.FirstOrDefault(s => s.Id == id);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                Console.WriteLine("Студента видалено.");
            }
            else
            {
                Console.WriteLine("Студента з таким ID не знайдено.");
            }
        }

        public void SearchStudent(List<Student> students)
        {
            Console.Write("Введiть ID студента для пошуку: ");
            int id = int.Parse(Console.ReadLine());

            var student = students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                Console.WriteLine($"Знайдений студент:{student.Surname} {student.Name} {student.Group}");
            }
            else
            {
                Console.WriteLine("Студента з таким ID не знайдено.");
            }
        }

        public void SortStudents(List<Student> students)
        {
            var sortedStudents = students.OrderBy(s => s.Surname).ToList();
            Console.WriteLine("Список студентiв (за зростанням):");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Surname} {student.Name} {student.Group}");
            }
        }

        public void SortStudentsDescending(List<Student> students)
        {
            var sortedStudents = students.OrderByDescending(s => s.Surname).ToList();
            Console.WriteLine("Список студентiв (за спаданням):");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.Surname} {student.Name} {student.Group}");
            }
        }
    }
}
