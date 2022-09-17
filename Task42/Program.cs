// 42. Напишите программу которая будет преобразоввывать
// десятичное число в двоичное
// 45 - 101101
// 3 - 11
// 2 - 10
// 13 - 1101

Console.Write("Введите первое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int ChangeToBin(int a)
{
    int result = 0;
    int mult = 1;
    while (a > 0)
    {
        result += a % 2 * mult; //или result = result + a % 2 * mult
        a /= 2; // или a = a /2
        mult *= 10;
    }
    return result;
}
int res = ChangeToBin(num);
Console.WriteLine(res);
