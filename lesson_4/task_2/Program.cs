// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = 0;
Console.WriteLine("Введите целое число: ");
while(true)
{
    try
    {
        number = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch
    {
        Console.Write("Нужно ввести целое число: ");
    }
}
number = Math.Abs(number);
int mysum = 0;
int digit = 1;
while(number > 0)
{
    digit = number % 10;
    number /= 10;
    mysum += digit;
}
Console.Write(mysum);