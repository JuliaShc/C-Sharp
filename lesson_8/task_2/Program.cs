// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
const int ROWS = 4;const int COLUMNS = 5;
const int LeftRange = 1; const int RightRange = 10;
void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            array[i,j] = new Random().Next(LeftRange, RightRange);  
        }
    }
}
void PrintArray(int[,] array)
{
   for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    } 
}
int[,] matrix = new int[ROWS,COLUMNS];
FillArray(matrix);
PrintArray(matrix);
int sum  = 0;
int minsum = 0;
int MinSumRowNumber = 0;
for(int row = 0;row < matrix.GetLength(0);row++)
{
    sum = 0;
    for(int column = 0;column < matrix.GetLength(1); column++)
    {
        sum += matrix[row,column];
    }
    Console.WriteLine($"Сумма {row + 1}-й строки: {sum} ");
    if(row == 0) minsum = sum; 
    if(sum < minsum)
    {
        minsum = sum;
        MinSumRowNumber = row;
    } 
     
}
Console.WriteLine($"Минимальная сумма элементов строки равна {minsum}");
Console.Write($"Номер строки с наименьшей суммой: {MinSumRowNumber + 1}");   