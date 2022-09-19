// 43: Напишите программу, которая 
// найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] array = new double[2, 2];
double[] point = new double[2];

Console.Write("Введите значение k1: ");
array[0, 0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1: ");
array[0, 1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
array[1, 0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
array[1, 1] = Convert.ToInt32(Console.ReadLine());

double[] IntersectionPoint(double[,] array)
{
    point[0] = (array[1, 1] - array[0, 1]) / (array[0, 0] - array[1, 0]);
    point[1] = array[0, 0] * ((array[1, 1] - array[0, 1]) / (array[0, 0] - array[1, 0])) + array[0, 1];
    
    if (array[0, 0] == array[1, 0] && array[0, 1] == array[1, 1]) Console.WriteLine("Прямые совпадают");
    else if (array[0, 0] == array[1, 0] && array[0, 1] != array[1, 1]) Console.WriteLine("Прямые параллельны");
    else Console.WriteLine($"Точка пересечения прямых с координатами: x = {point[0]}, y = {point[1]}");
    return point;
}
IntersectionPoint(array);



