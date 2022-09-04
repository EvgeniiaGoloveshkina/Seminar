// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19  [-4, -6, 89, 6] -> 0


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}

int OddNumbers(int[] myArray) 
{
    int result = 0;
    for (int i = 1; i < myArray.Length; i += 2) 
    {
        result += myArray[i];
    }
    return result;
}

int[] myArray = GetArray(5, -10,10);
Console.WriteLine(String.Join(" ", myArray)); 
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {OddNumbers(myArray)}");