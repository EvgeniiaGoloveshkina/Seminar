// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int row, int column)
{
    double[,] result = new double[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
             result[i, j] = new Random().NextDouble()*40-20; 
        }
    }
    return result;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2} \t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите кол-во строк : ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
double[,] myArray = GetArray(rows, columns);
PrintArray(myArray);