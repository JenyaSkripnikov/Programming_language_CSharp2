/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Например:
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if(number > 99 && number < 1000 || number <= -100 && number > -1000)
{
int firstDigit = number / 10;
int secondDigit = Math.Abs(firstDigit % 10);    
Console.WriteLine($"Число {number} второе порядковое число {secondDigit}");
}
else
Console.WriteLine($"Введенные данные некорректные");