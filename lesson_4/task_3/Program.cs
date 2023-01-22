//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
int arraylength = 8;
int[] array = new int[arraylength];

while(true)
{
    try
    {
        Console.Write("Введите 8 целых чисел через пробел: ");
        string[] inputarray = Console.ReadLine().Split(' ');
        if(inputarray.Length > array.Length)
        {
            Console.Write("Вы ввели больше значений, чем нужно! ");
            continue;
        }
        for (int i = 0; i < arraylength; i++)
        {
            array[i] = Convert.ToInt32(inputarray[i]);
        }
        break;
    }
    catch
    {
        Console.WriteLine("Ошибка!");
    }
}
Console.Write("Массив: ");

for(int i = 0;i < arraylength;i++)
{
    if(i == arraylength - 1)
    {
        Console.Write($"{array[i]}");
        break;
    }
    Console.Write($"{array[i]},");
}
  