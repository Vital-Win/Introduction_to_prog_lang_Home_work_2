// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Пожалуйста введите целое положительное число и нажмите Enter:");
string? numberString = Console.ReadLine()!;

int numberDigit = int.Parse(numberString);


if (numberDigit > 99)
{
    int[] a = numberString.Select(x => int.Parse(x.ToString())).ToArray();
    Console.WriteLine(a[2]); 
}
else if (numberDigit < 0)
{
    Console.WriteLine("Вы ввели отрицательное число");
}
else
{
    Console.WriteLine("третьей цифры нет");
}