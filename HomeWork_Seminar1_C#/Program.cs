﻿// Задача 2:Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Выполнено ниже:

// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int max;
// if (num1 > num2)
// {
//     max = num1;
//     Console.Write(max);
// }
// else 
// {
//     max = num2;
//     Console.Write(max);
// }   

// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// Выполнено ниже:

// Console.Write("Input a first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a therd number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
//     if (num2 > max)
//     {
//         max = num2;
//     }
//      if (num3 > max)
//     {
//         max = num3;
//     }
// Console.Write(max);

// Задача 6: Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// Выполнено ниже:

// Console.Write("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
//     Console.Write("The entered number is even");
// else 
//     Console.Write("The entered number is odd");

// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// Выполнено ниже:

// Console.Write("Input a positive number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int current = 2;
// while(current <= num)
// {
//     if(current % 2 == 0)
//         Console.Write(current + " ");
//         current++;
// }


