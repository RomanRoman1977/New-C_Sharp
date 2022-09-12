// 3. Напишите программу которая будет выдавать
// название дня недели по заданному числу
// 3 - Среда
// 5 - Пятница


/*Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
string day = "";
if(num >= 1 && num <= 7)
{
    switch (num)
    {
    case 1:
        day = " Понедельник";
        break;
    case 2:
        day = " Вторник";
        break;
    case 3:
        day = " Среда";
        break;
    case 4:
        day = " Четверг";
        break;
    case 5:
        day = " Пятница";
        break;
    case 6:
        day = " Суббота";
        break;
    case 7:
        day = " Воскресенье";
        break;
    }
    Console.WriteLine("День недели:" + day);
}
else
{
    Console.WriteLine("Не корректное число");
}*/

Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num == 1) {
    Console.WriteLine($"{num} - Понедельник");
} else if(num == 2) {
    Console.WriteLine($"{num} - Вторник");
} else if(num == 3) {
    Console.WriteLine($"{num} - Среда");
} else if(num == 4) {
    Console.WriteLine($"{num} - Четверг");
} else if(num == 5) {
    Console.WriteLine($"{num} - Пятница");
} else if(num == 6) {
    Console.WriteLine($"{num} - Суббота");
} else if(num == 7) {
    Console.WriteLine($"{num} - Воскресенье");
} else {
    Console.WriteLine("Введено не корректное число");
}
