// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

namespace Seminar8
{
    class Task2
    {
        static void Main(string[] args)
        {
            int m = new Random().Next(1, 11);
            int n = new Random().Next(1, 11);
            int[,] array = new int[m, n];
            FillArray(array);
            Console.WriteLine("Введите позицию элемента в двумерном массиве.");
            Console.WriteLine("номер строки (от 1 до 10):");
            int str = CheckInputNumbers();
            Console.WriteLine("номер столбца (от 1 до 10):");
            int column = CheckInputNumbers();
            Console.WriteLine($"Случайно сгенерированный двумерный массив с количеством строк {m} и коллличеством столбцов {n}");
            PrintArray(array);
            if (str > array.GetLength(0) || column > array.GetLength(1)) Console.WriteLine("Такого элемента нет!");
            else Console.WriteLine($"Такаой элемент есть и равен: {array[str - 1, column - 1]}");

        }

        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
                }
            }
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int CheckInputNumbers()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number > 10 || number < 1)
            {
                Console.WriteLine("Ошибка ввода! Введите целое число от 1 до 10 ");
            }
            return number;

        }
    }
}