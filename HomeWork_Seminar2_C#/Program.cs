// Задача10. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Выполнено:

// int SecondDigit(int num) /* метод оочень долгий... можно оказывается одной строкой */
// {
// 	int tencut = num / 10; /* тоесть показывает(берет) из числа 456 45 */
//     int firstcut = tencut % 10; /* тоесть показывает(берет) из числа 45 5 */
// 	int result = firstcut;

// 	return result;
// }
/* А еще лучше написать вот так. ОООЧень коротко:*/
// int secondDigit = num / 10 % 10;
/* И ВСЕ!!*/

Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 || num >= 1000)
{
    Console.WriteLine("You input not a there-digrit number");
    return;
}
int secondDigit = num / 10 % 10;
// int digit = SecondDigit(num);
Console.WriteLine($"Second digit from the number {num} is {secondDigit}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int GetThirdRank(int num) 
// {
// 	while (num > 999) 
//     {
//         num /= 10;/* Это значит, когда число делят на 10, если оно больше чем 3 цифры, то отсекается по одной пока число не будет из 3 цифр */
//     }
//     return num % 10;/* и из этих 3 цифр показывается остаток последняя цифра, Тоесть 3 цифра и в трезначном и четырех и пяти значном и т.д.*/
// }  

// bool ValidateNumber(int num)
// {
//     if(num < 100)
//     {
//         Console.WriteLine($"{num} do not have a thurd digrit");
//         return false;
//     }
//     return true;
// }

// Console.Write("Input a positive number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(ValidateNumber(num))
// {
//     Console.Write(GetThirdRank(num));
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Выполнено:

// bool Day(int num)
// {
//     return (num <= 5);
// }
      
// Console.Write("Input a number day of a week: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool result = Day(num);
// {
//     if(result)
//         Console.WriteLine($"The week day number {num} is а work day. You still have to work!) ");
//     else
//         Console.WriteLine($"The week day number {num}  is a day off. You can ralax!)) ");
// }
