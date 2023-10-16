// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.WriteLine("Введите число А: ");
// int numA = Convert.ToInt32(System.Console.ReadLine());
// int A = numA;
// System.Console.WriteLine("Введите число B: ");
// int numB = Convert.ToInt32(System.Console.ReadLine());
// int B = numB;

// if (numA > numB)
//     System.Console.WriteLine($"Максимальное -> A = {numA}, минимальное -> B = {numB}");
// else
// {
//     System.Console.WriteLine($"Максимальное -> B = {numB}, минимальное ->B = {numA}");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.WriteLine("Введите число А: ");
// int A = Convert.ToInt32(System.Console.ReadLine());
// int numA = A;
// System.Console.WriteLine("Введите число B: ");
// int B = Convert.ToInt32(System.Console.ReadLine());
// int numB = B;
// System.Console.WriteLine("Введите число C: ");
// int C = Convert.ToInt32(System.Console.ReadLine());
// int numC = C;

// int max = numA;

// if (A > max) max = A;
// if (B > max) max = B;
// if (C > max) max = C;

// System.Console.Write("Mаксимальное число -> ");
// System.Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// System.Console.Write("Введите любое число: ");
// int num = Convert.ToInt32(System.Console.ReadLine());
// int remain = num % 2;
// if (remain == 0)
// {
//     Console.WriteLine("Число " + num + " четное!");
// }
// else
// {
//     Console.WriteLine("Число " + num + " нечетное!");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// System.Console.Write("Input digit: ");
// int number = Convert.ToInt32(System.Console.ReadLine());
// int even = 2;

// while (number >= even)
// {
//     Console.Write(even + " ");
//     even += 2;
// }

// ДОМАШНЕЕ ЗАДАНИЕ ВТОРОГО СЕМИНАРА

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.WriteLine("Введите любое 3-х значное число: ");
// int num = int.Parse(Console.ReadLine() ?? "0");
// double digit = Math.Log10(num);
// digit = (int)digit;

// if (digit == 2)
// {
//     int result = num / 10;
//     result = result % 10;
//     Console.WriteLine("Вторая цифра числа -> " + result);
// }
// else
// {
//     Console.WriteLine("Введенное число не является 3-х значным!!!");
//     Console.WriteLine("Введите 3-х значное число!!!");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.WriteLine("Введите число");
// char[] num = Console.ReadLine().ToCharArray();

// if (num.Length > 2)
//  {
//     Console.Write("Третья цифра в числе: ");
//     Console.Write(num);
//     Console.Write(", равняется -> ");
//     Console.WriteLine(num[2]);
//  }
// else
// {
//     Console.Write("Третья цифра в числе: ");
//     Console.Write(num);
//     Console.WriteLine(", отсутствует!");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Решение 1

// Console.WriteLine("Enter digit day of week from 1 to 7: ");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day == 6 || day == 7)
//     {
//         Console.WriteLine($"{day} is weekend day.");
//     }
//     else
//     {
//         Console.WriteLine($"{day} is not weekend day.");
//     }

// Решение 2

// Console.WriteLine("Input numbers from 1 to 7");
// string? inputNum = Console.ReadLine();

// if (inputNum != null)
// {
//     int nameDay = int.Parse(inputNum);
//     string DayOfWeek = string.Empty;
//     switch (nameDay)
//     {
//         case 1: DayOfWeek = "Monday, working day"; break;
//         case 2: DayOfWeek = "Tuesday, working day"; break;
//         case 3: DayOfWeek = "Wednesday, working day"; break;
//         case 4: DayOfWeek = "Thursday, working day"; break;
//         case 5: DayOfWeek = "Friday, working day"; break;
//         case 6: DayOfWeek = "Saturday, weekend"; break;
//         case 7: DayOfWeek = "Sunday, weekend"; break;
//         default: DayOfWeek = "This is not a day of the week!"; break;
//     }
//     Console.WriteLine(DayOfWeek);
// }

// ЗАДАЧА 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Введите число A:");
//         int A = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("\nВведите степень B:");
//         int B = Convert.ToInt32(Console.ReadLine());

//         double result = Math.Pow(A, B);
//         Console.WriteLine($"Результат: {result}");
//     }
// }
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int ReadDataStr(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// void PrintData(string msg, int res)
// {
//     Console.WriteLine(msg + res);
// }

// int SummaNumDigChar(int num)
// {
//     int res = 0;

//     string str = num.ToString();
//     for(int i = 0; i < str.Length; i++)
//     {   
//         res = res + (str[i] - '0');
//     }
//     return res;
// }


// int number = ReadDataStr("Введите положительное, целое число: ");

// int summaChar = SummaNumDigChar(number);


// PrintData("Сумма цифр числа равна: ", summaChar);
// Console.WriteLine(" ");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// int[] Gen1DArr(int num, int begin, int end)
// {
//     Random rnd = new Random();
//     int[] arr = new int[num];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(begin, end);
//     }
//     return arr;
// }

// void Print1DArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length-1; i++)
//     {
//         Console.Write(arr[i]+", ");
//     }
//     Console.WriteLine(arr[arr.Length-1]+"]");
// }

// int arrLen = ReadData("Введите длину массива: ");
// int arrFirst = ReadData("Введите левый диапазон эл-тов: ");
// int arrEnd = ReadData("Введите правый диапазон эл-тов: ");

// int[] arr = Gen1DArr(arrLen, arrFirst, arrEnd);

// Print1DArr(arr);

// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
//

// int countPositive(int[] array)
// {
//   int count = 0;
//   for (int i = 0; i < array.Length; i++)
//   {
//     if (array[i] > 0)
//       count++;
//   }
//   return count;
// }

// int[] inputInt(int M)
// {
//   int[] array = new int[M];
//   for (int i = 0; i < M; i++)
//   {
//     Console.Write("Введите целое число: ");
//     array[i] = int.Parse(Console.ReadLine());
//   }
//   return array;
// }

// Console.Write("Введите кол-во целых чисел: ");
// int M = int.Parse(Console.ReadLine());
// int[] array = inputInt(M);
// Console.Write($"Ввели {countPositive(array)} положительных чисел");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// 

// // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int PromptInt(string prompt)
// {
//     Console.Write(prompt);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// double PromptFloat(string prompt)
// {
//     Console.Write(prompt);
//     double result = Convert.ToDouble(Console.ReadLine());
//     return result;
// }

// double[,] SetArray(int rows, int columns, double min, double max)
// {
//     Random rand = new Random();
//     double[,] result = new double[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = rand.NextDouble() * max + min;
//         }
//     return result;
// }

// void ShowArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]:f2}\t ");
//         }
//         if (i < array.GetLength(0) - 1)
//             Console.WriteLine();
//         else
//            Console.Write(" ");
//     }
// }

// int rows = PromptInt("Введите количество строк в массиве: ");
// int columns = PromptInt("Введите количество столбцов в массиве: ");
// double min = PromptFloat("Введите минимальное значение для элементов в массиве: ");
// double max = PromptFloat("Введите максимальное значение для элементов в массиве: ");
// double[,] array = SetArray(rows, columns, min, max);
// ShowArray(array);

// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

// int PromptInt(string prompt)
// {
//     Console.Write(prompt);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[,] SetArray(int rows, int columns, int min, int max)
// {
//     Random rand = new Random();
//     int[,] result = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//         {
//             result[i, j] = rand.Next(min, max);
//         }
//     return result;
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j], 3}");
//         }
//         Console.Write("]");
//         Console.WriteLine();
//     }
// }

// int rows = PromptInt("Введите количество строк: ");
// int columns = PromptInt("Введите количество столбцов: ");
// int min = PromptInt("Введите минимальное значение элемента: ");
// int max = PromptInt("Введите максимальное значение элемента: ");
// int[,] array = SetArray(rows, columns, min, max);
// ShowArray(array);
// int row = PromptInt("Введите номер строки: ");
// int col = PromptInt("Введите номер столбца: ");
// ShowArray(array);
// Console.Write($"{row}{col} -> ");
// if (row > rows || col > columns)
//     Console.WriteLine("Такой элемент отсутствует");
// else
//     Console.WriteLine($"{array[row - 1, col - 1]}");

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.
//
// int PromptInt(string prompt)
// {
//   Console.Write(prompt);
//   int result = Convert.ToInt32(Console.ReadLine());
//   return result;
// }

// int[,] SetArray(int rows, int columns, int min, int max)
// {
//   Random rand = new Random();
//   int[,] result = new int[rows, columns];
//   for (int i = 0; i < rows; i++)
//     for (int j = 0; j < columns; j++)
//     {
//       result[i, j] = rand.Next(min, max);
//     }
//   return result;
// }

// void ShowMatrix(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//       for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write($"{array[i, j],3}");
//     }
//     Console.WriteLine();
//   }
// }

// double[] GetMean(int[,] array)
// {
//   double[] result = new double[array.GetLength(1)];
//   int rows = array.GetLength(0);
//   int columns = array.GetLength(1);
//   int sum;
//   for (int i = 0; i < columns; i++)
//   {
//     sum = 0;
//     for (int j = 0; j < rows; j++)
//     {
//       sum += array[j, i];
//     }
//     result[i] = sum / Convert.ToDouble(rows);
//   }
//   return result;
// }

// void ShowArray(double[] array)
// {
//   Console.Write("[");
//   for (int i = 0; i < array.Length; i++)
//   {
//     Console.Write($"{array[i]:f2} {(i < array.Length - 1 ? ";" : "] -> ")}");
//   }
// }

// int rows = PromptInt("Введите количество строк: ");
// int columns = PromptInt("Введите количество столбцов: ");
// int min = PromptInt("Введите минимальное значение элемента: ");
// int max = PromptInt("Введите максимальное значение элемента: ");
// int[,] array = SetArray(rows, columns, min, max);
// ShowMatrix(array);
// double[] means = GetMean(array);
// ShowArray(means);

﻿// Исходная матрица:
// 9   1   7
// 1   2   3
// 4   5   6
//
// Матрица с упорядоченными по убыванию строками:
// 9   7   1
// 3   2   1
// 6   5   4
//
// 

// ﻿using System;

// public class Answer
// {
//   public static int SumOfRow(int[,] matrix, int row)
//   {
//     // Введите свое решение ниже
//     int sum = 0;
//     int columns = matrix.GetLength(1);
//     for (int col = 0; col < columns; col++)
//     {
//       sum += matrix[row, col];
//     }
//     return sum;
//   }

//   public static int[] MinimumSumRow(int[,] matrix)
//   {
//     // Введите свое решение ниже
//     int[] result = new int[2];
//     int rows = matrix.GetLength(0);
//     int min = int.MaxValue;
//     int tmpMin;
//     for (int i = 0; i < rows; i++)
//     {
//       tmpMin = SumOfRow(matrix, i);
//       if (min > tmpMin)
//       {
//         min = tmpMin;
//         result[0] = i;
//         result[1] = min;
//       }
//     }
//     return result;
//   }

//   // Не удаляйте и не меняйте метод Main!
//   public static void Main(string[] args)
//   {
//     int[,] matrix;
//     if (args.Length == 0)
//     {
//       // Если аргументы не переданы, используем матрицу по умолчанию
//       matrix = new int[,]
//       {
//                 { 5, 2, 9 },
//                 { 8, 1, 4 },
//                 { 6, 7, 3 }
//       };
//     }
//     else
//     {
//       // Иначе, парсим аргументы в двумерный массив
//       string[] rows = args[0].Split(';');
//       matrix = new int[rows.Length, rows[0].Split(',').Length];
//       for (int i = 0; i < rows.Length; i++)
//       {
//         string[] elements = rows[i].Split(',');
//         for (int j = 0; j < elements.Length; j++)
//         {
//           if (int.TryParse(elements[j], out int number))
//           {
//             matrix[i, j] = number;
//           }
//           else
//           {
//             Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//             return;
//           }
//         }
//       }
//     }

//     Console.WriteLine("Исходная матрица:");
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         Console.Write($"{matrix[i, j]}\t");
//       }
//       Console.WriteLine();
//     }

//     int[] minSumRow = MinimumSumRow(matrix);

//     Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
//   }
// }

﻿using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
            Console.WriteLine("It is impossible to multiply.");
        else
            PrintMatrix(MatrixMultiplication(matrixA, matrixB));
    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
        int rows = matrixA.GetLength(0);
        int columns = matrixB.GetLength(1);
        int[,] result = new int[rows, columns];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = ScalarMultiplication(
                    GetRowOrColFromMatrix(matrixA, i, 0),
                    GetRowOrColFromMatrix(matrixB, j, 1)
                );
            }
        return result;
    }

    public static int ScalarMultiplication(int[] matrixA, int[] matrixB)
    {
        int size = matrixA.Length;
        int result = 0;
        for (int i = 0; i < size; i++)
        {
            result += matrixA[i] * matrixB[i];
        }
        return result;
    }

    public static int[] GetRowOrColFromMatrix(int[,] matrix, int Number, int Shape)
    {
        //int rows = matrix.GetLength(0);
        int row,
            col;
        int numbers = matrix.GetLength(Shape ^ 1);
        int[] result = new int[numbers];
        for (int i = 0; i < numbers; i++)
        {
            row = Shape == 0 ? Number : i;
            col = Shape == 1 ? Number : i;
            System.Console.WriteLine($"row={row}; col={col}; i={i}");
            result[i] = matrix[row, col];
        }
        return result;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        // Введите свое решение ниже
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    // Не удаляйте и не меняйте метод Main!
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                { 2, 4 },
                { 1, 3 },
                { 5, 6 }
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        int[,] matrixB =
        {
            { 5, 6 },
            { 7, 8 }
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}