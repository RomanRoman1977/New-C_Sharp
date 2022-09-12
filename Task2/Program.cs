// 2: Напишите программу,
//  которая на вход принимает 
//  два числа и выдаёт, 
//  какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите значение № 1: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение № 2: ");
int num_2 = Convert.ToInt32(Console.ReadLine());


if (num_1 > num_2)
{
    Console.WriteLine($"{num_1} больше {num_2}");
}
else
{
    Console.WriteLine($"{num_2} больше {num_1}");
}
if (num_1 == num_2)
{
    Console.WriteLine("Значения равны");
}
