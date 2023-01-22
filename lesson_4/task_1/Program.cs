// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!
int A = 0;
int B = 0;

while(true)
{
    try
    {
        Console.Write("Введите первое число: ");
        A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите второе число: ");
        B = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Для вычислений необходимо ввести  целые числа! ");
    }
}  
int result = 1;
if(B < 0)
{
    int B1 = B * -1;
    for(int i = 0;i < B1; i++)
    {
        result *= A;
    }
    double res   =  result; 
    res = 1 / res; 
    Console.Write(res);
}
else
{
    for(int i = 0;i < B; i++)
    {
        result *= A;
    }
    Console.Write(result);
}



