// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
int n = 1;
while(true)
{
    Console.Write("Введите целое число: ");
    try
    {        
        n = Convert.ToInt32(Console.ReadLine());
        if(n==0)
        {
            Console.WriteLine("Для вычислений число должно быть отличным от 0!");
            continue;
        }
        else break;                 
    }
    catch 
    {
        Console.Write("Нужно ввести целое число: ");    
    }
}
int [] numbers = new int[Math.Abs(n)];

if (n < 0) Console.Write($"Список кубов от -1 до {n}: ");
else if (n > 0) Console.Write($"Список кубов от 1 до {n}: ");

for(int i = 0; i < Math.Abs(n);i++) 
{
    if(n < 0) numbers[i] = (i + 1)* -1;
    else numbers[i] = i + 1;

    int res = numbers[i] * numbers[i] * numbers[i];   

    if(i + 1 == Math.Abs(n)) Console.Write(res);
    else Console.Write($"{res}, ");
}