// /* Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2 */

// Console.Write("Input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [rows, columns];

// int[,] CreatRandom2dArray(int[,] array)
// {
//     for(int i = 0; i < rows; i++) 
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
    
// }

// int[,] newArray = CreatRandom2dArray(numbers);
// Console.WriteLine("Array of random numbers: ");
// Show2dArray(newArray);

// void SortedNamerInLine(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }
// Console.WriteLine();
// Console.WriteLine($"Array of sorted numbers: ");
// SortedNamerInLine(newArray);
// Show2dArray(newArray);
// /* Задача 54 end */




// /*Задача 56
// // // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// */
// Console.Write("Input a number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [rows, columns];

// int[,] CreatRandom2dArray(int[,] array)
// {
//     for(int i = 0; i < rows; i++) 
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             array[i,j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
    
// }

// int[,] newArray = CreatRandom2dArray(numbers);
// Console.WriteLine("Array of random numbers: ");
// Show2dArray(newArray);

// int SumLineElements(int[,] newArray, int i)
// {
//   int sum = newArray[i,0];
//   for (int j = 1; j < newArray.GetLength(1); j++)
//   {
//     sum += newArray[i,j];
//   }
//   return sum;
// }

// int minSumLine = 0;
// int sumLine = SumLineElements(newArray, 0);
// for (int i = 1; i < newArray.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(newArray, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"The row #{minSumLine + 1} has a smaller sum of elements, equal to {sumLine}.");
// /*Задача 54 end*/



// /* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

// int rowsA = InputNumbers("Enter the number of rows of the 1st matrix: ");
// int columnsA = InputNumbers("Enter the number of columns of the 1st matrix: ");
// int rowsB = InputNumbers("Enter the number of rows of the 2nd matrix: ");
// int columnsB = InputNumbers("Enter the number of columns of the 2nd matrix: ");
// if (columnsA != rowsB)
// {
//   Console.WriteLine("Such matrices cannot be multiplied!");
//   return;
// }
// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// } 

// int[,] CreatRandom2dArray(int rows, int columns, int min, int max )
// {
//     int[,] result = new int[rows, columns];
//     for(int i = 0; i < rows; i++) 
//     {
//         for(int j = 0; j < columns; j++)
//         {
//             result[i,j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void Show2dArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++) 
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i,j] + " ");

//         Console.WriteLine();
//     }
    
// }

// int[,] firstMartrix = CreatRandom2dArray(rowsA, columnsA, 1, 10);
// Console.WriteLine("The 1st matrix:");
// Show2dArray(firstMartrix);

// int[,] secondMartrix = CreatRandom2dArray(rowsB, columnsB, 1, 10);
// Console.WriteLine("The 2nd matrix:");
// Show2dArray(secondMartrix);

// int[,] MultiplicationMatrix(int[,] arrayA, int[,] arrayB)
// {
//   int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//   for (int i = 0; i < arrayA.GetLength(0); i++)
//     for (int j = 0; j < arrayB.GetLength(1); j++)
//       for (int k = 0; k < arrayA.GetLength(1); k++)
//         arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
//   return arrayC;
// }
// Console.WriteLine("The  multiplication of the first and second matrices:");
// Show2dArray(MultiplicationMatrix(firstMartrix, secondMartrix));
// /* Задача 58 end */

// /* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/ 

// Console.WriteLine("Enter the size of the array X x Y x Z:");
// int x = InputNumbers("Enter X: ");
// int y = InputNumbers("Enter Y: ");
// int z = InputNumbers("Enter Z: ");
// Console.WriteLine($"");

// int[,,] array3D = new int[x, y, z];
// CreatRandom3DArray(array3D);
// Show3DArray(array3D);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void Show3DArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreatRandom3DArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }
// /* Задача 60 end */

// // /* Задача 62: Заполните спирально массив 4 на 4.
// // 1 2 3 4
// // 12 13 14 5
// // 11 16 15 6
// // 10 9 8 7 */

// int n = 10;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// ShowArray(sqareMatrix);

// void ShowArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }