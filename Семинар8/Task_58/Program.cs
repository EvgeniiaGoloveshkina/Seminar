// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void FillArray(int[,] firstMartrix, int[,] secondMartrix)
{
    for (int i = 0; i < firstMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMartrix.GetLength(1); j++)
        {
            firstMartrix[i, j] = new Random().Next(1, 10);
        }
    }
    for (int i = 0; i < secondMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMartrix.GetLength(1); j++)
        {
            secondMartrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] firstMartrix, int[,] secondMartrix)
{
    for (int i = 0; i < firstMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMartrix.GetLength(1); j++)
        {
            Console.Write($"{firstMartrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < secondMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMartrix.GetLength(1); j++)
        {
            Console.Write($"{secondMartrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] mult)
{
    for (int i = 0; i < firstMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMartrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < secondMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
                mult[i, j] = sum;
            }
        }
    }
}
void PrintMultArray(int[,] mult)
{
    for (int i = 0; i < mult.GetLength(0); i++)
    {
        for (int j = 0; j < mult.GetLength(1); j++)
        {
            Console.Write($"{mult[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк первой матрицы: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы : ");
int column1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int column2 = int.Parse(Console.ReadLine());
int[,] firstMartrix = new int[row1, column1];
int[,] secondMartrix = new int[row2, column2];
int[,] mult = new int[row1, column2];
// if (column1!=row2) Console.WriteLine("Произведение матриц не определено: ");
// else 
FillArray(firstMartrix, secondMartrix);
PrintArray(firstMartrix, secondMartrix);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
MultiplyMatrix(firstMartrix, secondMartrix, mult);
PrintMultArray(mult);