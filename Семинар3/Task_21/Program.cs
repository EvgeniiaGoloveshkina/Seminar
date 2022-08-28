// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84,   A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Write("Введите x1 : ");
int x1=int.Parse(Console.ReadLine());
Console.Write("Введите y1 : ");
int y1=int.Parse(Console.ReadLine());
Console.Write("Введите z1 : ");
int z1=int.Parse(Console.ReadLine());
Console.Write("Введите x2 : ");
int x2=int.Parse(Console.ReadLine());
Console.Write("Введите y2 : ");
int y2=int.Parse(Console.ReadLine());
Console.Write("Введите z2 : ");
int z2=int.Parse(Console.ReadLine());

double d=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
Console.WriteLine($"d= {d:f2}");