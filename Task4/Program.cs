// 4: Напишите программу, 
// которая принимает на вход 
// три числа и выдаёт максимальное 
// из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите значение № 1: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение № 2: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение № 3: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2 & num_1 > num_3)
{
    Console.WriteLine($"Максимальное значение {num_1}");
}
else if (num_2 > num_1 & num_2 > num_3)
{
    Console.WriteLine($"Максимальное значение {num_2}");
}
else if (num_3 > num_1 & num_3 > num_2)
{
    Console.WriteLine($"Максимальное значение {num_3}");
}
if (num_1 == num_2 & num_1 == num_3)
{
    Console.WriteLine("Значения равны");
}
