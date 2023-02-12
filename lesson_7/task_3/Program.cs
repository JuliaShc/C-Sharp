// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
double sum = 0;
double[] result = new double[matrix.GetLength(1)];
for(int j = 0; j < matrix.GetLength(1); j++)
{
    sum = 0;
    for(int i = 0; i < matrix.GetLongLength(0); i++)
    {
        sum += matrix[i,j];
    }
    result[j] = sum / matrix.GetLength(0);
}
Console.Write("Среднее арифметическое столбцов: ");
for(int i = 0; i < result.Length; i++)
{
    Console.Write($"{result[i]}; ");
}