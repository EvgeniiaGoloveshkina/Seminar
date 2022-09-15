// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
//  выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] InitMatrix(int row, int column)
{
    int[,] matrix = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }

}
void SearchMinimumSum(int[,] matrix, int minSumm)
{
    int number = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            summa = summa + matrix[i, j];
        }
        if (summa < minSumm)
        {
            number = i;
            minSumm = summa;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {number + 1}"); //Нумерация начинается с 1
}
Console.Write("Введите количество строк матрицы: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int column = int.Parse(Console.ReadLine());
int[,] matrix = InitMatrix(row, column);
int MinSumm = 1000;
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);
SearchMinimumSum(matrix, MinSumm);