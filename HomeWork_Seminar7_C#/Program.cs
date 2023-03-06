/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9  */

// double[,] CreatRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//         double[,] array = new double[rows, columns];
//         Random random = new Random();
//         Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Yellow;

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 array[i, j] = Math.Round((random.NextDouble()), 1);
//             }
//         }
//         return array;
// }        

// void Show2dArray(double[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of minValue: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of maxValue: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// double[,] newArray = CreatRandom2dArray(rows, columns, minValue, maxValue);
// Show2dArray(newArray);


/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> элемента с такими индексами в массиве нет */

// int[,] CreatRandom2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     Console.WriteLine();
//     for(int i = 0; i < array.GetLength(0); i++) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
    
// }

// Console.Write("введите номер строки: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите номер столбца: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int [,] numbers = new int [5, 5];
// CreatRandom2dArray(numbers);
// Show2dArray(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
//     Console.WriteLine("");
// }



/*  Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */

// int[,] CreatRandom2dArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     Console.WriteLine();
//     for(int i = 0; i < array.GetLength(0); i++) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите кол-во столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int [,] numbers = new int [n, m];
// CreatRandom2dArray(numbers);
// Show2dArray(numbers);


    
// for(int j = 0; j < numbers.GetLength(1); j++)
// {
//     double count = 0;
//     for(int i = 0; i < numbers.GetLength(0); i++) 
//     {
//         count = (count + numbers[i, j]); 
//     }
//     count = count / n; 
//     Console.Write(count + "; ");        
// } 
     


