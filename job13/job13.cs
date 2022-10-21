/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Например:
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Введите число: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if(number >= 100 && number < 1000 || number <= -100 && number > -1000)
    Console.WriteLine($"{number}, третья цифра {Math.Abs(number % 10)}");
if(number > -100 && number < 100)
    Console.WriteLine($"{number}, третьей цифры нет");
if(number >= 1000 || number <= -1000)
    Console.WriteLine($"Введенные данные некорректные");    
