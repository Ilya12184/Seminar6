/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

Console.Write("Введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double x = 0;
double y = 0;
if (k1 != k2)
{
    x = (b2-b1)/(k1-k2);
    y = k1*x+b1;

    Console.WriteLine($"Точка пересечения: x = {x}, y = {y}");
}
else
{
    Console.WriteLine("Нельзя делить на ноль!");
}

