using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using КП6.HelperClasses;

namespace КП6.Tasks
{
    public class Task1
    {
        HelperTask1 helperTask1 = new HelperTask1 ();
        public void Execute()
        {
            Console.WriteLine("Введiть розмiр матрицi:");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("Розмiр матрицi повинен бути бiльше нуля.");
                return;
            }

            int[,] matrix = new int[n, n];
            Console.WriteLine("Вибери спосiб заповнення:" +
                "\n1 - Випадковi числа" +
                "\n2 - Одиницями" +
                "\n3 - Ромбом iз нулiв");

            if (!int.TryParse(Console.ReadLine(), out int fillChoice))
            {
                Console.WriteLine("Неправильний ввід.");
                return;
            }

            switch (fillChoice)
            {
                case 1:
                    helperTask1.RandomFilling(matrix);
                    break;
                case 2:
                    helperTask1.OneFilling(matrix);
                    break;
                case 3:
                    helperTask1.DiamondFilling(matrix);
                    break;
                default:
                    Console.WriteLine("Неправильно введене число");
                    return;
            }

            helperTask1.PrintMatrix(matrix);
            Console.WriteLine("Натисніть будь-яку клавішу для повернення до меню...");
            Console.ReadKey();
        }
    }
}
