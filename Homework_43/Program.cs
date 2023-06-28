/*
Задача 43
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем
*/

void findDecision(double b1, double k1, double b2, double k2)
{
    double x;
    double y;
    if (k1 == k2 && b1 == b2)
    {
       Console.WriteLine("Прямые совпадают"); 
    }
    else
        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны");
        }
        else
        {
        x = (b2-b1)/(k1-k2);
        y = k1*x + b1;
        Console.WriteLine($"x is {x}, y is {y}");
        }
}

Console.WriteLine ("Введите b1, k1, b2, k2");
double myB1 = Convert.ToInt32(Console.ReadLine());
double myK1 = Convert.ToInt32(Console.ReadLine());
double myB2 = Convert.ToInt32(Console.ReadLine());
double myK2 = Convert.ToInt32(Console.ReadLine());
findDecision(myB1, myK1, myB2, myK2);

