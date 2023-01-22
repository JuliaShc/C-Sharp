// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int number = 0;
while (true)
{
    Console.Write("Введите целое трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if(number < 1000 & number >= 100)
        break;
    Console.WriteLine("Число не является трехзначным! ");
}
int SecondDigit = number / 10 % 10;
Console.Write($"Вторая цифра числа - {SecondDigit}");