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

double X(double k1, double k2, double b1, double b2)
{
    return (b2 - b1) / (k1 - k2);
}

double Y(double x, double k1, double b1)
{
    return k1 * x + b1;
}

double inputDouble(string promt)
{
    Console.Write(promt);
    return Convert.ToDouble(Console.ReadLine());
}

bool ValidateLines(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        if (b1 == b2)
            Console.WriteLine("Прямые совдадают");
        else
            Console.WriteLine("Прямые параллельны");

        return false;
    }
    return true;
}

Console.WriteLine("Для уравнений вида y=k*x+b");
double k1 = inputDouble("Введите к1: ");
double b1 = inputDouble("Введите b1: ");
double k2 = inputDouble("Введите к2: ");
double b2 = inputDouble("Введите b2: ");
if (ValidateLines(k1, b1, k2, b2))
{
    double x = X(k1, k2, b1, b2);
    double y = Y(x, k1, b1);
    Console.WriteLine($"Для уравнений y={k1}*x+{b1} и y={k2}*x+{b2}");
    Console.WriteLine($"Общая точка имеет координаты ({x}; {y})");
}