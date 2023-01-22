// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
const int size = 123;
const int leftRange = 0;
const int riteRange = 150;
int[] GetRandomArray(int size, int leftRange, int riteRange)
{
        int[] array = new int[size];
        for(int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(leftRange,riteRange + 1 );        
        }
        return array;    
}
int[] array = GetRandomArray(size,leftRange, riteRange);
int number = 0;
for(int i = 0; i < size; i++)
{
    if(array[i] > 10 & array[i] < 100)
    {
        number++;
    }
}

Console.Write($"В массиве \n{string.Join(",", array)} \nколичество элементов, значения которых лежат в отрезке [10,99] составляет {number}  ");