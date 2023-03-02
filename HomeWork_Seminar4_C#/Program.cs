// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵) 2, 4 -> 16

// int Promt(string message)
// {
//     Console.Write(message);
//     string readInput = Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }

// int Exponentiation(int powerBase, int power)
// {
//     int exponent = 1;
//     for (int i = 0; i < power; i++)
//     {
//         exponent *= powerBase;
//     }
//     return exponent;
// }

// bool ValidatePover(int power)
// {
//     if (power <= 0)
//     {
//         Console.WriteLine("Степень возведения не должна быть нулем или меньше нуля");
//         return false;
//     }
//     return true;
// }

// Console.Write("Введите число: ");
// int powerBase = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень возведения числа: ");
// int power = Convert.ToInt32(Console.ReadLine());
// if (ValidatePover(power))
// {
//     Console.WriteLine($"Число {powerBase} в степени {power} равно {Exponentiation(powerBase, power)}");
// }



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11, 82 -> 10, 9012 -> 12

// int GetSum(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
//     }
//     return result;
// }
// Console.Write("Enter your number ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = GetSum(number);
// Console.WriteLine($"Сумма всех чисел в цифре {number} = {result}");

// Задача 29: Напишите программу, которая задаёт массив из m элементов и 
// выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "");
    }
    Console.WriteLine();
}
Console.Write("input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);


