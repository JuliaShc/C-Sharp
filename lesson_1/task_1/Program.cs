// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7

Console.Write("Введите первое число: ");
int veriable1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int veriable2 = Convert.ToInt32(Console.ReadLine());

if(veriable1 > veriable2)
{
    Console.Write($"max =  {veriable1}   ");
}
else if(veriable1 == veriable2)
{
    Console.Write("Числа одинаковые ");
}
else
{
    Console.Write($"max =  {veriable2}   ");
}
