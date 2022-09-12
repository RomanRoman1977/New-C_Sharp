// 14. Напишите програииу которая принимает
// на вход число и проверяет кратно ли оно 7 и 23
// 14 - нет
// 46 - нет
// 161 - да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}
bool result = Multiplicity(number);
Console.WriteLine(result ? "Да" :  "Нет");
