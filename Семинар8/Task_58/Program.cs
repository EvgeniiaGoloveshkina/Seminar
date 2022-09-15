// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int[,] GetArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] GetMultArray(int[,] firstMartrix, int[,] secondMartrix)
{
    if (firstMartrix.GetLength(1) == secondMartrix.GetLength(0))
    {
        int[,] matrixMult = new int[firstMartrix.GetLength(0), secondMartrix.GetLength(1)];

        for (int k = 0; k < firstMartrix.GetLength(1); k++)
        {
            for (int i = 0; i < firstMartrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMartrix.GetLength(1); j++)
                {
                    matrixMult[i, j] += firstMartrix[i, k] * secondMartrix[k, j];
                }
            }
        }
        return matrixMult;
    }
    else
    {
        Console.WriteLine("Произведение матриц не определено");
        int[,] matrixMult = new int[0, 0];
        return matrixMult;
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
int[,] firstMartrix = GetArray(row1, column1);
int[,] secondMartrix = GetArray(row2, column2);
Console.WriteLine("Первая матрица ");
PrintArray(firstMartrix);
Console.WriteLine("Вторая матрица ");
PrintArray(secondMartrix);
int[,] matrixMult = GetMultArray(firstMartrix, secondMartrix);
Console.WriteLine("Произведение матриц ");
PrintArray(matrixMult);