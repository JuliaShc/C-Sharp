// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.WriteLine("Задайте размер квадратной матрицы, необходимо ввести целое число,считается что Вы - идеальный пользователь");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];
int step = 0;
int digit = 1;
if(n%2 == 1)
{
    array[n/2, n/2] = n*n;
}

for(int v = 0; v < n / 2; v++)
{ 
    for(int i = 0;i < (n-step); i++)
    {
        array[v, i+v] = digit;
        digit += 1;   
    }
    for(int i = v + 1; i < (n- v); i++)
    {
        array[i, n-v-1] = digit;
        digit +=1;
    }
    for(int i = v + 1; i < (n-v); i++)
    {
        array[n-v-1,n-i-1] = digit;
        digit +=1;
    }
     for(int i = v +1; i < (n -v- 1);i++)
     {
        array[n-i-1, v] = digit;
        digit +=1;
    }
    step += 2;
}
for(int i = 0;i < n; i++)
{
    for(int j = 0; j < n; j++)
    {
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}
        
        
        
       




