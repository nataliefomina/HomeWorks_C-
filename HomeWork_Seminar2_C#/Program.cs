// Задача10. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Выполнено:

// int SecondDigit(int num)
// {
// 	int tencut = num / 10;
//     int firstcut = tencut % 10;
// 	int result = firstcut;

// 	return result;
// }

// Console.Write("Input a three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int digit = SecondDigit(num);
// Console.WriteLine($"Second digit from the number {num} is {digit}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Выполнено:

// int ThirdDigit(int num)
// {
// 	if(num > 99)
//     {
//         int result = (num / 100) % 10;
//         return result;
//     }
//     else
//     {
//         int wrong = -1;
//         return wrong;
//     }
// }  

// Console.Write("Input a positive number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int digit = ThirdDigit(num);
// Console.WriteLine($"The Third digit of number {num} is {digit}");

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Выполнено:

bool Day(int num)
{
    return (num <= 5);
}
      
Console.Write("Input a number day of a week: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = Day(num);
{
    if(result)
        Console.WriteLine($"The week day number {num} is а work day. You still have to work!) ");
    else
        Console.WriteLine($"The week day number {num}  is a day off. You can ralax!)) ");
}
