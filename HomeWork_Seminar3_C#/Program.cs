// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 > нет;  12821 -> да; 23432 -> да
// Выполнено
// Console.WriteLine ("Введите 5-ти значное число: ");
// string number = Console.ReadLine();
// int length = number.Length;/* Length это индексы массива */

// if (length == 5) /* Length это индексы массива */
// {
//     if (number[0] == number[4] && number [1] == number[3])/* число 23432 тоесть 2=2 нулевой и 4 индекс */
//     {
//         Console.WriteLine(number + " Палиндром");
//     }

//     else
//     {
//         Console.WriteLine(number + " Не палиндром");
//     }
// }
// else
// {
//     Console.WriteLine ("Вы ввели НЕ 5-и значное число");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Выполнено хотя какаято фигня...

// int x1 = ReadInt("Введите х для точки 1: ");
// int y1 = ReadInt("Введите y для точки 1: ");
// int z1 = ReadInt("Введите z для точки 1: ");
// int x2 = ReadInt("Введите х для точки 2: ");
// int y2 = ReadInt("Введите y для точки 2: ");
// int z2 = ReadInt("Введите z для точки 2: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z2 - z1;

// double length = Math.Round(Math.Sqrt(A * A + B * B + C * C));/* Math.Sqrt математическая функция которая извлекает квадратный корень */
// Console.WriteLine("Расстояние = " + length);

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125 

int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i++) /* оперант for вместо while */
{
    Console.Write($"{i * i * i}, ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}