/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2   1, -7, 567, 89, 223-> 3*/
// int Promt(string message)
// {
//     System.Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }

// int[] InputArray(int Length)
// {
//     int[] array = new int[Length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Promt($"Enter {i + 1} element: ");
//     }
//     return array;
// }

// void ShowArray(int[] array)

// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.WriteLine($"a[{i}] = {array[i]}");
//     }
// }

// int CountPositive(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         if(array[i] > 0)
//         {
//             count++;
//         }
        
//     return count;
// }

// int length = Promt("Enter how many elements the array will contain: ");
// int[] array;
// array = InputArray(length);
// ShowArray(array);
// Console.WriteLine($"The number of elements is greater than 0 - {CountPositive(array)}");

/* Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Write("input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

int Intersection(int b1, int b2,int k1,int k2,)
{
    int y = 0;
    int
}