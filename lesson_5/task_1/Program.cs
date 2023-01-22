// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int size, int leftRange, int riteRange)
{
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(leftRange,riteRange + 1 );        
        }
        return array;    
}
const int leftRange = 0;
const int riteRange = 150;
int size;
Console.Write("Введите целое число, чтобы задать размер массива: ");
while(true)
{
    try
    {
        size = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch
    {
        Console.Write("Введите целое число, чтобы задать размер массива: ");
    }
}
int[] array = GetRandomArray(size,leftRange,riteRange);
int number = 0;
for(int i = 0; i < size;i++)
{
    if(array[i] % 2 == 0)
    {
        number++;
    }
}

Console.Write($"В массиве {string.Join(",", array)}  количество четных чисел: {number}  ");