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