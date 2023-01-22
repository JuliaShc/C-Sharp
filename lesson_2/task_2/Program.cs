// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string ? number = "";
Console.Write("Введите целое число: ");
while(true)
{
    number = Console.ReadLine();
    if(number == string.Empty)
    {
        Console.Write("Вы не ввели значение! Введите целое число:");
        continue;
    }
    try
    {
        int isnumber = Convert.ToInt32(number);
        break;
    }
    catch
    {
        Console.Write("Вы  ввели не число! Введите целое число:");    
    }
}
if (number.Length < 3)
{
    Console.Write("Третьей цифры нет");
}
else
{
    Console.Write(number[2]);
}
