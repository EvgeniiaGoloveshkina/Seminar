// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}
void PrintArray(int[,] whole)
{
    for (int i = 0; i < whole.GetLength(0); i++)
    {
        for (int j = 0; j < whole.GetLength(1); j++)
        {
            Console.Write($"{whole[i, j]} \t");
        }
        Console.WriteLine();
    }
}
double[] AverageColumns(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    int count = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            average[count] += array[j, i];
        }
        average[count] = average[count] / array.GetLength(0);
        average[count] = Math.Round(average[count], 1);
         count++;
    }
    return average;
}
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] myArray = GetArray(rows, columns);
Console.WriteLine("Исходный массив: ");
PrintArray(myArray);
double[] average = AverageColumns(myArray);
Console.WriteLine($"Среднее арифметическое столбцов : {String.Join(";", average)}");
