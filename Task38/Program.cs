// 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] ArrayRndDoub(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * 100;
        
        Console.Write(array[i] + " ");
    }
    return array;
}

double Difference(double[] arr)
{
    double maxElem = arr[0];
    double minElem = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (maxElem < arr[i]) maxElem = arr[i];
        if (minElem > arr[i]) minElem = arr[i];
    }
    Console.WriteLine("]");
    Console.WriteLine($"Максимальный элемент массива: {maxElem}");
    Console.WriteLine($"Минимальный  элемент массива: {minElem}");
    double diff = maxElem - minElem;
    return diff;
}
double[] array = ArrayRndDoub(4);
double diff = Difference(array);
System.Console.WriteLine($"Разница между ними равна: {diff}");
