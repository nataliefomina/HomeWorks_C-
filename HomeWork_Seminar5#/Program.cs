/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2*/

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++) 
//     {
//         array[i] = new Random().Next(100, 999);
//     }
//     return array;
// }
// void ShowArray(int[] array)

// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(size);
// ShowArray(newArray);
// int count = 0;

// int CountEvenNumbers(int[] newArray)
// {
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         if(newArray[i] %2 ==0)
//         count++;
//     }
//     return count;
// }
// Console.Write($"Number of even numbers is {CountEvenNumbers(newArray)}");

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0 */

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++) 
//     {
//         array[i] = new Random().Next(10);
//     }
//     return array;
// }
// void ShowArray(int[] array)

// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.Write("input a quantity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(size);
// ShowArray(newArray);
// int count = 0;


// int CountEvenNumbers(int[] newArray)
// {
//     for(int i = 1; i < newArray.Length; i = i + 2) 
//     {
//        count += newArray[i];
//     }
//     return count;
// }
// int sum2 = CountEvenNumbers(newArray);
// Console.Write($"Number of even numbers is {sum2}");

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++) 
    {
        array[i] = new Random().Next(10);
    }
    return array;
}
void ShowArray(int[] array)

{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(size);
ShowArray(newArray);

int DiffMaxMin(int[] newArray)
{
    int result = 0;
    int max = 0;
    int min = 0;
    for(int i = 0; i < newArray.Length; i++) 
    {
        if (newArray[i] > newArray[max])
            max = i;
        else if
        (newArray[i] < newArray[min])
            min = i;

    }
    result = newArray[max] - newArray[min];
    return result;
}
int diff = DiffMaxMin(newArray);
Console.Write($"difference between max and min number is {diff}");