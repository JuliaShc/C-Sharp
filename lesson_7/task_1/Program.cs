// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
const int ROWS = 4;const int COLUMNS = 5;
const int LeftRange = -10; const int RightRange = 10;
void FillDoubleArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            array[i,j] = Math.Round(new Random().Next(LeftRange, RightRange) * new Random().NextDouble(), 1);  
        }
    }
}
void PrintArray(double[,] array)
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
double[,] matrix = new double[ROWS,COLUMNS];
FillDoubleArray(matrix);
PrintArray(matrix);