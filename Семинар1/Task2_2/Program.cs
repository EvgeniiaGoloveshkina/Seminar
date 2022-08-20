//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число");
int number1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2=int.Parse(Console.ReadLine());

int max= number1;
if (number2>max) max=number2;

Console.Write("max=");
Console.WriteLine(max);

 
