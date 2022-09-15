// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] InitMatrix(int n)
{
    int[,,] matrix = new int[n, n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                matrix[i, j, k] = new Random().Next(1, 10) * 10 + new Random().Next(0, 10);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n; k++)
            {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k})  ");
            }
             Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int n = 2;
int[,,] matrix = InitMatrix(n);
PrintMatrix(matrix, n);