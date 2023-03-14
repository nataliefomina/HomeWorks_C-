/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */

// int m = 0;
// Console.Write("Input a number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// void Chek(int n)
// {
//     if (n < 1)
//     Console.WriteLine("Sorry, we only work with natural numbers.");
//     else
//     ShowNumber(n, m);
// }

// int ShowNumber(int n, int m)
// {
//     if(n == m) 
//         return n;
//     else    
//         Console.Write($"{ShowNumber(n, m + 1)} ");
//     return m;
// }
// Chek(n);

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

// Console.Write("Input a first number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a last number: ");
// int m = Convert.ToInt32(Console.ReadLine());
         
// int SumNam(int n, int m)
// {
//     if(n == m) 
//         return m;
//     return m + SumNam(n, m -1);  
// }   

// Console.Write($"The sum of the numbers between {n} and {m} = {SumNam(n, m)}");

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Input a number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}