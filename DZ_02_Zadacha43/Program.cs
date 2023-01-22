/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void IntersectionPoint (int k1, int b1, int k2, int b2)
{
    if (k1 == k2 & b1 == b2) 
    {
        Console.Write("Заданные две линии совпадают (одна и та же линия)");
    }
    else
    {
        if (k1 == k2 & b1 != b2)
        {
            Console.Write("Заданные две линии параллельны");
        } 
        else 
        {   
            double x = (b2 - b1)/ (k1 - k2);
            double y = k2 * x + b2;
            Console.Write($"Точкой пересечения двух линий является ({x},{y})");
        }
    }
}

Console.Write("Введите значения k1 и b1 для первой прямой y = k1 * x + b1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значения k2 и b2 для второй прямой y = k2 * x + b2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());

IntersectionPoint (k1, b1, k2, b2);