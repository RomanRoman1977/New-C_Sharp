// 26. Напишите программу которая принимает на вход
// число и выдает количество цифр в нем
// 456 - 3
// 78 - 2
// 89126 - 5

// Решаем через while
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// while(num >= 10)
// {
//     num = num / 10;
//     count++;
// }
// Console.WriteLine($"Количество цифр в числе = {count}");

// Решаем через for
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// for (; num >= 10; num = num / 10)
// {
//     count++;
// }
// Console.WriteLine($"Количество цифр в числе = {count}");

// Решаем через метод
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;

int CountNumber(int num)
{
    while (num >= 10)
    {
        num = num / 10;
        count++;
    }
    return count;
}
int res = CountNumber(number);
Console.WriteLine($"Количество цифр в числе {number} = {res}");
