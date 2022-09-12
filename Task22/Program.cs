// 22. Напишате программу которая принимает
// на вход число (N) и выдает таблицу квадратов
// от 1 до N
// 5 - 1,4,9,16,25
// 2 - 1,4

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count <= n)
{
    Console.WriteLine($"{count} | {Math.Pow(count, 2)}");// 2 - возводит в квадрат, 3 - в куб и т.д.
    count++;
}
