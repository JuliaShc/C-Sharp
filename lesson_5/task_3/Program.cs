// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int mysum = 0;
int [] array = GetRandomArray(size,leftRange,riteRange);
for(int i = 0; i < size; i++)
{
    if(i % 2 == 1)
    {
        mysum += array[i];
    }
}
Console.Write($"В массиве: \n{string.Join(",", array)} \nсумма элементов, стоящих на нечётных позициях, составляет {mysum}.  ");