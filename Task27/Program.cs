// 27: Напишите программу, 
// которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (number == 0) Console.WriteLine($"Сумма цифр в {number} = {number}");
else
{
    int SumNumber(int num)
    {
        while (num > 0)
        {
            sum = num % 10 + sum;
            num = num / 10;
        }
        return sum;
    }
    int res = SumNumber(number);
    Console.WriteLine($"Сумма цифр в {number} = {res}");
}
