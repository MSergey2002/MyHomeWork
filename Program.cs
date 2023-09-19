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