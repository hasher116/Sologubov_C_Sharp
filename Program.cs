using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sologubov_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                try
                {
                    Console.WriteLine("Выберите действие:\n" +
                        "1. Если введенное число больше 7, то вывести \"Привет\"\n" +
                        "2. Если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести \"Нет такого имени\"\n" +
                        "3. На входе есть числовой массив, необходимо вывести элементы массива кратные 3\n" +
                        "4. Завершить программу");
                    Console.Write("\nДействие - ");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:
                            {
                                FirstTask();
                                break;
                            }
                        case 2:
                            {
                                SecondTask();
                                break;
                            }
                        case 3:
                            {
                                ThirdTask();
                                break;
                            }
                        case 4:
                            {
                                return;
                            }
                        default:
                            {
                                Console.WriteLine("Введено некорректное число");
                                break;
                            }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы должны ввести число");
                }
                Console.WriteLine("\nДля продолжения нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void FirstTask()
        {
            try
            {
                double number;
                Console.Write("Введите число: ");
                number = double.Parse(Console.ReadLine());
                if (number > 7)
                {
                    Console.WriteLine("Привет");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы должны ввести число");
            }
        }

        static void SecondTask()
        {
            string name;
            Console.WriteLine("Введите имя: ");
            name = Console.ReadLine();
            if (name == "Вячеслав")
            {
                Console.WriteLine("Привет, Вячеслав");
            }
            else
            {
                Console.WriteLine("Нет такого имени");
            }
        }

        static void ThirdTask()
        {
            try
            {
                double[] array;
                int count;
                Console.Write("Введите размерность массива - ");
                count = int.Parse(Console.ReadLine());
                if (count < 1)
                {
                    throw new IndexOutOfRangeException("Размерность массива меньше 1");
                }
                array = new double[count];
                Console.WriteLine("Введите массив:");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = double.Parse(Console.ReadLine());
                }
                double[] newArray = array.Where(x => x % 3 == 0)
                    .ToArray();

                Console.WriteLine("\nЭлементы массива, кратные 3: ");
                foreach (var number in newArray)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы должны ввести число");
            }
        }
    }
}
