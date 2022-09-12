//33. Задайте массив. Напишите программу которая определяет
// присутствует ли заданное число в массиве
// 4; массив [6,7,19,345,3] - нет
// 3; [6,7,19,345,3] - да
Console.Clear();
int[] GreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size; i ++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i ++)
    {
        if(i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

bool FindElemIntArray(int[] array, int elem)
{
    bool ret = false;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] == elem)
        {
            ret = true;
            break;
        }
        
    }
    return ret;
}
Console.WriteLine("Введите число: ");
int findI = Convert.ToInt32(Console.ReadLine());
int[] arr = GreateArrayRndInt(10, -10, 10);
PrintArr(arr);
bool search = FindElemIntArray(arr, findI);

// if(search) Console.WriteLine("Присутствует в массиве");
// else Console.WriteLine("Отсутствует в массиве");
Console.WriteLine(search ? $"Число {findI} присутствует в массиве." : $"Чмсло {findI} отсутствует в массиве.");



// string TrueFalse(int[] array, int num)
// {
//     Console.Write($"Введите число");
//     int num = 0;
//     for (int i = 0; i < array.Length; i ++)
//     {
//         if(num == array[i])
//             Console.WriteLine($"Да, введенное число присутствует в массиве");
//         else
//             Console.WriteLine($"Нет, введенное число не присутствует в массиве");
//     }
// }
// int[] arr = GreateArrayRndInt(10, -10, 10);
// PrintArr(arr);
// TrueFalse(num);
