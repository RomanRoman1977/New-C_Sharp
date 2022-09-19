// 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] array = new int[5];

Console.WriteLine("Введите 5 чисел: ");
Console.Write("1 число: ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("2 число: ");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("3 число: ");
array[2] = Convert.ToInt32(Console.ReadLine());
Console.Write("4 число: ");
array[3] = Convert.ToInt32(Console.ReadLine());
Console.Write("5 число: ");
array[4] = Convert.ToInt32(Console.ReadLine());

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

void PositivNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)

        if(array[i] > 0)
        {
            sum++;
        }
        Console.WriteLine($"Количество чисел больше 0 = {sum++}");   
}
PrintArray(array);
PositivNum(array);

// Несовсем понял как решать задачу,строкой не сумел.

