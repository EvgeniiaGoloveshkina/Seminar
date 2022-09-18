// Задача 66: Задайте значения M и N.
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int m, int n)
{
    if (m == n) return n;
    return m+ SumNumbers(m + 1, n);
}

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
SumNumbers(number1,number2);
Console.WriteLine($"Сумма элементов в промежутке между {number1} и {number2} равна {SumNumbers(number1,number2)} ");