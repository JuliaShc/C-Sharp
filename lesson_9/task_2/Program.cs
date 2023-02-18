// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNums(int n,int m)
{
    if(n ==  m) return n;
    return m + SumNums(n, m-1);
}    
Console.Write(SumNums(5,7));