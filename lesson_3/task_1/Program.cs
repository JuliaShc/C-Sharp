// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да  

// Способ 1
int  number = 1;
Console.Write("Введите целое 5-ти значное число: ");
while(true)
{
    try
    {
        number = Convert.ToInt32(Console.ReadLine());
        if(number < 0)
        {
            Console.Write("Необходимо ввести положительное число: ");
            continue;
        }
        else if((Convert.ToString(Math.Abs(number)).Length != 5))
        {
            Console.Write("Необходимо ввести пятизначное число: ");
            continue;
        }
        break;
    }
    catch
    {
        Console.Write("Необходимо ввести пятизначное число: ");    
    }
}

if( number / 10000 == number % 10 & number / 1000 % 10 == number / 10 % 10) Console.Write("Да");
else Console.Write("нет");




