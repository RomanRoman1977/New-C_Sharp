// 25: Напишите цикл, 
// который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 1;
int degree = 1;

while (count <= b)
{
    degree = degree * a;
    count++;
}
Console.WriteLine($"Число {a} возведенное в натуральную степень числа {b} = {degree}");
