// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
int[,] matrix1 = new int[ROWS,COLUMNS];
int[,] matrix2 = new int[ROWS,COLUMNS];
int[,] result = new int[ROWS,COLUMNS];
FillArray(matrix1);
FillArray(matrix2);
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);

for(int i = 0;i < matrix1.GetLength(0); i++)
{
    for(int j = 0;j < matrix1.GetLength(1); j++)
    {
        result[i,j] = matrix1[i,j] * matrix2[i,j];
    }
}
Console.WriteLine("Произведение матриц:");
PrintArray(result);