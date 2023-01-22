// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
string[] inputline; 
double k1; double b1; double k2; double b2;
double result1; double result2;
while(true)
{
      try
    {        
        Console.WriteLine("Для уравнений y = k1 * x + b1  и y = k2 * x + b2  введите через пробел значения  k1 b1 k2 b2:  ");
        inputline = Console.ReadLine().Split(" ");
        int[] line  = new int[inputline.Length];
        for(int i = 0;i < inputline.Length; i++)
        {
            line[i] = Convert.ToInt32(inputline[i]);
        }
         if(inputline.Length != 4)
        {
             Console.WriteLine("Hеобходимо указать 4 целых числа.  ");
             continue;
        } 
        k1 = line[0]; 
        b1 = line[1];
        k2 = line[2];
        b2 = line[3];   
        break;
    }   
    catch 
    {
        Console.Write("Ошибка! Неверные данные!  ");
    }
}
result1 = (b2 - b1) / (k1 - k2);
result2 = k1 * (b2 - b1) / (k1 - k2) + b1;
Console.Write($"Координаты точки пересечения прямых: x = {result1}, y = {result2}.");