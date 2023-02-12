// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​Например, задан массив:
// ​1 4 7 2
// ​5 9 2 3
// ​8 4 2 4
// ​1 7 -> такого числа в массиве нет
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
int row = 1; int column = 1;
while(true)
{
    try
    {        
        Console.Write("Введите номер строки: ");
        row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите номер столбца: ");
        column = Convert.ToInt32(Console.ReadLine());
        break;
        
    }
    catch
    {
        Console.WriteLine("Значение должно быть целым числом.");
    }
}
try
{
    Console.Write($"На этом месте находится цифра {matrix[row, column]}");
}
catch
{
    Console.Write("Такой позиции в массиве нет");
}