﻿// 10: Напишите программу,
//  которая принимает на вход 
//  трёхзначное число и на выходе
//   показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    int result = number / 10 % 10;
    Console.WriteLine($"Вторая цифра введенного числа {result}");
}
else Console.WriteLine("Введено некорректное число");
