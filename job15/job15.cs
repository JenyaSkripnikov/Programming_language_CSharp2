/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Например:
6 -> да
7 -> да
1 -> нет
*/
Console.WriteLine("1 - Понедельник");
Console.WriteLine("2 - Вторник");
Console.WriteLine("3 - Среда");
Console.WriteLine("4 - Четверг");
Console.WriteLine("5 - Пятница");
Console.WriteLine("6 - Суббота");
Console.WriteLine("7 - Воскресенье");
Console.WriteLine("Введите день недели от 1 до 7: ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if(number > 0 && number < 6)
    Console.WriteLine($"{number} -> будний день");
if(number > 5 && number < 8)
    Console.WriteLine($"{number} -> Выходной день");
if(number < 1 || number > 7)
    Console.WriteLine($"Введенные данные некорректные");