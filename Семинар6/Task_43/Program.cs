 //Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] FindCoord(double b1, double k1, double b2, double k2)
{
    double[] result = new double[2];
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = k1 * result[0] + b1;
    return result;
} 

Console.Write("Введите число b1: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k1: ");
int numk1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b2: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число k2: ");
int numk2 = Convert.ToInt32(Console.ReadLine());
double[] Coord = FindCoord(numb1, numk1, numb2, numk2);
if (numb1 == numb2 && numk1 ==  numk2)
  {
    Console.Write($"Прямые совпадают");
  }
  else if (numb1 == numb2 && numk1 !=  numk2) 
  {
    Console.Write($"Прямые параллельны");
  }
  else 
Console.WriteLine($"Координаты точки пересечения прямых: ({Coord[0]:f1};{Coord[1]:f1})");

