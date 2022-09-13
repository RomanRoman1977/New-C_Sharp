// 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, 
// стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] num = new int[4];

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

int SumOddElements(int[] array)
{
    int sumElem = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumElem = sumElem + array[i];
        }
    }
    return sumElem;
}
CreateArrayPosElem(num, 0, 10);
PrintArray(num);
Console.WriteLine();
int sumElem = SumOddElements(num);
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях в массиве: {sumElem}");