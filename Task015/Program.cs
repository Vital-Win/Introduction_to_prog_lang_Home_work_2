// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Программа, которая проверяет является ли день недели выходным");
Console.WriteLine("Пожалуйста введите НОМЕР дня недели от 1 до 7 и нажмите Enter:");
string? numberString = Console.ReadLine()!;
int number = int.Parse(numberString);

if (number == 6 || number == 7)
{
    Console.WriteLine("да");
} 
else if (number > 0 && number <= 5)
{
    Console.WriteLine("нет");
} 
else
{
    Console.WriteLine("Введите число от 1 до 7");
} 