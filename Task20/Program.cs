// 20. Напишите программу которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве
// А (3,6); В (2,1) -> 5,09
// А (7,-5); В (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Pifagor(int xc1, int yc1, int xc2, int yc2)
{
    return Math.Sqrt((xc2 - xc1)*(xc2 - xc1) + (yc2 - yc1)*(yc2 - yc1));
}
double result = Pifagor(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками A {x1},{y1} и B {x2},{y2} = {Math.Round(result,1)}");
// Math.Round - округляет результат до необходимого нам знака.
