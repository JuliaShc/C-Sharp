// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
const int N = 8;
const int M = 1;
void PrintNums(int n, int m)
{
    if(n == m - 1) return;
    PrintNums(n,m + 1);
    Console.Write($"{m} ");
} 
PrintNums(N,M);


