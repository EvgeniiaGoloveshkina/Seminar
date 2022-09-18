// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
int AckermannFunction(int m, int n) {
        if (m == 0) 
        {
            return n + 1;
        }
        else if (n == 0 && m > 0) 
        {
            return AckermannFunction(m - 1, 1);
        }
        else 
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }

Console.Write("Введите число M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Функция Аккермана от {number1}, {number2} равна {AckermannFunction(number1,number2)}");