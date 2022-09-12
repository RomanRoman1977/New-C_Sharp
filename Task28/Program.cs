// 28: Напишите программу которая
// принимает на вход число N и выдает 
// произведение числе от 1 до N
// 4 - 24
// 5 - 120

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int MultN(int n)
{
    int m = 1;
    for (int i = 1; i <= n; i++) m *= i;
    return m;
}
int mult = MultN(num);
Console.WriteLine($"Произведение числе от 1 до {num} = " + mult);

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int mult = 1;

// for (int i = 1; i <= n; i++)
// {
//     mult *= i;
// }
// Console.WriteLine($"Произведение числе от 1 до {n} = " + mult);
