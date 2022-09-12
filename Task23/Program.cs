// 23. Напишате программу которая принимает
// на вход число (N) и выдает таблицу кубов числе
// от 1 до N
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count <= n)
{
    Console.WriteLine($"{count} | {Math.Pow(count, 3)}");// 2 - возводит в квадрат, 3 - в куб и т.д.
    count++;
}

