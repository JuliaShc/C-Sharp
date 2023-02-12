// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int n = 10;
const int width = 2;
const int length = 2;
const int height = 2;
int[, ,] array = new int[width, length, height]; 

for(int x = 0; x < width; x++)
{   
    for (int y = 0; y < length; y++)
    {   
        for (int z = 0; z <height; z++)
        {
            array[x, y, z] = n++;
            Console.Write($"{array[x, y, z]}({x}, {y}, {z})  ");      
        } 
        Console.WriteLine();
    }
    
}

