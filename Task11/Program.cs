﻿// 11. Напишите программу которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа
// 456 - 46
// 782 - 72
// 918 - 98

int DeleteMiddleDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    int result = firstDigit * 10 + secondDigit;
    return result;
}

int number = new Random().Next(100, 1000);

int res = DeleteMiddleDigit(number);
Console.WriteLine($"Сгенерированное число {number}, обработанное число {res}");
