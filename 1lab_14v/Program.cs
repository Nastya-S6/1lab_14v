using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_14v
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            var userVariable = Convert.ToInt32(Console.ReadLine());
            if (userVariable <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nМассив не может быть сгенерирован из отрицательного числа\n");
                Console.ReadLine();
                return;
                //throw new Exception("Массив не может быть сгенерирован из отрицательного числа");
            }
            Random randomVariable = new Random();
            int[] Massiv = new int[userVariable];
            for (var cycle = 0; cycle < userVariable; cycle++)
            {
                Massiv[cycle] = randomVariable.Next(-10, 10);
            }
            Console.WriteLine("Сгенерированный массив: " + string.Join(" ", Massiv));

        }
    }
}




