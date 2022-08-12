// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Пожалуйста введите положительное трёхзначное целое число и нажмите Enter:");
string? numberString = Console.ReadLine()!;
int threeDigitNumber = int.Parse(numberString);

int twoDigitNumber = threeDigitNumber / 10;
int ourNumber = twoDigitNumber % 10;

if (threeDigitNumber > 99 && threeDigitNumber <= 999)
{
    Console.WriteLine("Вторая цифра этого числа " + ourNumber);
}
else if (threeDigitNumber < 0)
{
    Console.WriteLine("Вы ввели отрицательное число");
}
else
{
    Console.WriteLine("Вы ввели НЕ трехзначное число");
}