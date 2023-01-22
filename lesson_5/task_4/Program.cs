// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetRandomArray(int size, int leftRange, int riteRange)
{
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(leftRange,riteRange + 1 );        
        }
        return array;    
}
int size;
int leftRange;
int riteRange;
Console.WriteLine("Введите целые числа, чтобы задать  массив: ");
while(true)
{
    try
    {   Console.Write("Количество элементов: ");  
        size = Convert.ToInt32(Console.ReadLine());
        Console.Write("Нижняя граница диапазона: ");
        leftRange = Convert.ToInt32(Console.ReadLine()); 
        Console.Write("Верхняя граница диапазона: ");
        riteRange = Convert.ToInt32(Console.ReadLine());
        break;
    }
    catch
    {
        Console.WriteLine("Введите целые числа, чтобы задать  массив: ");
    }
}
int [] array = GetRandomArray(size,leftRange,riteRange);
int max = array[0];
int min = array[1];
if(array[0] < array[1])
{
   array[1] = array[0];
}
for(int i = 0;i < size - 2; i++)
{
    if(array[i + 2] > max) max = array[i + 2];
    if(array[i + 2] < min) min = array[i + 2];   
}
Console.Write($"В массиве {string.Join(",", array)} \nMax = {max}, Min = {min},\nразница между максимальным и минимальным элементом массива составляет {max - min}.");