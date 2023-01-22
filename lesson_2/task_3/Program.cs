// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


string [] daynumbers =  {"нет","нет","нет","нет","нет","да","да",};
string ? number = null;
int daynumber = 1;
Console.Write("Введите целое число: ");
while(true)
{
    number = Console.ReadLine();
    if(number == null)
    {
        Console.Write("Вы не ввели значение! Введите целое число: ");
        continue;
    }
    try
    {
        daynumber = Convert.ToInt32(number);
        if (daynumber < 1 | daynumber> 7)
        {
            Console.Write("В неделе 7 дней, введите число от 1 до 7: ");
        }
        else
        {
            break;
        }
    }
    catch
    {
        Console.Write("Вы  ввели не число! Введите целое число:");    
    }
}
Console.Write(daynumbers[daynumber]);6
