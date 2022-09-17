// 45. Напишите программу которая будет создавать
// копию заданного массива с помощью поэлементного копирования

int[] GreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

int[] CopyArray(int[] array)
{
    int[] copy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copy[i] = array[i];
    }
    // проверяем тот ли массив печатается добавляем эту строку - copy[0] = 2022;
    return copy;
}
int[] arr = GreateArrayRndInt(4, 0, 10);
PrintArr(arr);
int[] copyArr = CopyArray(arr);
PrintArr(copyArr);

