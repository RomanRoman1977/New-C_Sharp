// 18. Напишите программу которая
// по заданному номеру четверти
// покахывает диапазон возможных
// координат точек в этой четверти (x и y)

Console.WriteLine("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

string QuartNum(int num)
{
    if (num == 1) return "Значение переменных: x > 0, y > 0";
    if (num == 2) return "Значение переменных: x < 0, y > 0";
    if (num == 3) return "Значение переменных: x < 0, y < 0";
    if (num == 4) return "Значение переменных: x > 0, y < 0";
    return "Введена некорректная четверть";
}
string result = QuartNum(number);
Console.WriteLine(result);