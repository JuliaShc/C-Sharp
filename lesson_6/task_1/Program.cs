// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
Console.WriteLine("Введите целые числа через пробел, для окончания ввода наберите слово 'stop' и нажмите 'Enter': ");
int count = 0;
string[] inputarray;
int[] array;
while(true)
{
    inputarray = Console.ReadLine().Split(" ");
    array = new int[inputarray.Length];
    try
    {
        for(int i = 0; i < inputarray.Length; i++)
        {
            if(inputarray[i] == "stop") break;
            array[i] = Convert.ToInt32(inputarray[i]);
            // if(array[i] > 0) count ++; 
        } 
        if(inputarray[inputarray.Length - 1] != "stop")
        {
            Console.WriteLine( "Ввод чисел останавливается при помощи  стоп-слова 'stop', пожалуйста, введите числа снова: ");
            continue;
        } 
        for(int i = 0; i < inputarray.Length; i++)
        {
            if(array[i] > 0) count ++; 
        }
        break;
    }
    catch
    {
        Console.WriteLine("Вы ввели неверные данные! Введите целые числа через пробел, для окончания ввода наберите слово 'stop' и нажмите 'Enter':");
    }
    
}


Console.WriteLine($"Количество чисел больше 0, которые ввел пользователь ({string.Join(",", array[..(inputarray.Length - 1)])}), составляет {count}.");