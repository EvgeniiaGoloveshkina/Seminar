// Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.
// [3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
// [1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int[] Sorting(int[] myArray) 
{
 int bub;
    for (int i = 0; i < myArray.Length; i++)
    {
        for (int j = i + 1; j < myArray.Length; j++)
        {
            if (myArray[i] < myArray[j])
            {
                bub = myArray[i];
                myArray[i] = myArray[j];
                myArray[j] = bub;
            }                   
        }            
    }
    return myArray;
}

int[] myArray = GetArray(5, -10, 10);
Console.WriteLine($"Данный массив {String.Join(", ", myArray)}");
Console.WriteLine($"Отсортированный массив: {String.Join(", ", Sorting(myArray))}");
