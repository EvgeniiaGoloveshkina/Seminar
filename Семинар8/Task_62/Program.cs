// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] InitMatrix(int num)
{
    int[,] matrix = new int[num, num];
    int count = 1;
    int m = 0;
    int i = 0;
    int j = 0;
    int result = num * num;
    while (count <= result)
    {
        for (int k = m; k < num; k++)
        {
            matrix[i, k] = count;
            count++;
        }
        j = num - 1;
        for (int k = m + 1; k < num; k++)
        {
            matrix[k, j] = count;
            count++;
        }
        i = num - 1;
        for (int k = num - 2; k >= m; k--)
        {
            matrix[i, k] = count;
            count++;
        }
        j = m;
        for (int k = num - 2; k > m; k--)
        {
            matrix[k, j] = count;
            count++;
        }
        i = m + 1;
        num--;
        m++;
        j = m;

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t  ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = InitMatrix(4);
PrintMatrix(matrix);