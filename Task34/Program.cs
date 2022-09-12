// 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет
//  количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] num = new int[10];

void CreateArrayPosElem(int[] array, int min, int max)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length -1]);
    Console.Write("]");
}

int PositiveElements(int[] array)
{
    int posElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            posElem++;
        }
    }
    return posElem;
}
CreateArrayPosElem(num, 100, 1000);
PrintArray(num);
Console.WriteLine();
int posElem = PositiveElements(num);
Console.WriteLine($"Количество чётных чисел в массиве: {posElem}");
