// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
int[,] SortingMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1) - 1; k++)

        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {

                if (matrix[i, j] < matrix[i, j + 1])
                {
                    int temp = matrix[i, j + 1];
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }
    return matrix;
}
Console.Write("Введите количество строк матрицы: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int column = int.Parse(Console.ReadLine());
int[,] matrix = InitMatrix(row, column);
Console.WriteLine("Исходный массив: ");
PrintMatrix(matrix);
Console.WriteLine();
int[,] newmatrix = SortingMatrix(matrix);
Console.WriteLine("Отсортированный массив: ");
PrintMatrix(newmatrix);