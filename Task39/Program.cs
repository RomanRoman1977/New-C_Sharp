// 39. Напишите пограмму которая перевернет одномерный массив
// [1,2,3,4,5] - [5,4,3,2,1]
// [6,7,3,6] - [6,3,7,6]

Console.Clear();
int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

// Реализация через цикл while
// это то же самое что и встроенная в  dotnet функция "Array.Reverse(arr)"
// void ReverseArray(int[] array)
// {
//     int size = array.Length;
//     int index1 = 0;
//     int index2 = size - 1;

//     while (index1 < index2)
//     {
//         int obj = array[index1];
//         array[index1] = array[index2];
//         array[index2] = obj;
//         index1 ++;
//         index2 --;
//     }
// }

// Реализация через цикл for
void ReverseArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        int tamp = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = tamp;
    }
}

int[] arr = CreateArrayRndInt(5, 1, 15);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);



