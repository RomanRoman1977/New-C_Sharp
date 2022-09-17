// 40. Напишите программу которая принимает на вход три числа
// и проверяет может ли существовать треугольник со сторонами
// такой длини

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы
// двух других сторон."

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

// Первый вариант
// bool CheckTriangle(int a1, int b1, int c1)
// {
//     if (a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1)
//     {
//         return true;
//     }
//     return false;
// }
// bool result = CheckTriangle(a,b,c);
// if (result == true) Console.WriteLine("Три числа являются треугольником");
// else Console.WriteLine("Три числа не являются треугольником");

// Второй вариант вывод через тернарные операторы
bool CheckTriangle(int a1, int b1, int c1)
{
    return a1 + b1 > c1 && a1 + c1 > b1 && b1 + c1 > a1;
}
bool result = CheckTriangle(a,b,c);
Console.WriteLine(result ? "Три числа являются треугольником" : "Три числа не являются треугольником");

