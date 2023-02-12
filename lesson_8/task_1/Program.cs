// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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
Console.WriteLine("Масив с отсортированными по убыванию строками:");
for(int row = 0; row < matrix.GetLength(0); row++)
{
   for(int i = 1;i < matrix.GetLength(1); i++)
   {
    for(int j = i; j > 0; j--)
    {
        if(matrix[row,j] > matrix[row,j-1])
        {
            int tmp = matrix[row,j];
            matrix[row,j] = matrix[row,j-1];
            matrix[row,j-1] = tmp;
        }
        else
            break;
    }
   }  
}
PrintArray(matrix);  
