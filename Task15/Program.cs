// 15: Напишите программу, 
// которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
string day = "";

if (num >= 1 && num <= 7)
{
    switch (num)
    {
        case 1: case 2: case 3: case 4: case 5:
            day = "нет, это не выходной день недели.";
            break;
        case 6: case 7:
            day = "да, это выходной день недели!";
            break;
    }
    Console.WriteLine(day);
}
else Console.WriteLine("Введено некорректное число");
