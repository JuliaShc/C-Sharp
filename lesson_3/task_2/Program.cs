// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] d1 = {1,2,3};
int[] d2 = {1,2,3};
string [] d0 = {"x","y","z"};
while(true)
{    
    try
    {
        for (int i = 0; i < d1.Length; i++)
        {
            Console.Write($"Введите значение  координаты  {d0[i]} для первой точки: ");
            d1[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < d1.Length; i++)
        {
            Console.Write($"Введите значение  координаты  {d0[i]} для второй точки: ");
            d2[i] = Convert.ToInt32(Console.ReadLine());
        }
        break;
    }
    catch
    {
        Console.WriteLine("Для координат нужно ввести числовое значение ");
    }
}
double result = Math.Sqrt((d2[0]-d1[0])*(d2[0]-d1[0]) + (d2[1]-d1[1])*(d2[1]-d1[1]) + (d2[2]-d1[2])*(d2[2]-d1[2]));
Console.Write($"Расстояние между 2-мя точками: {result}");