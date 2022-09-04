//Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.  [3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble()*20-40;  //NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
    }
    return res;
}

double Diff(double[] myArray) 
{
    double result = 0;
    double Min = myArray[0], Max = myArray[0];
    for (int i = 1; i < myArray.Length; i ++) 
    {
        if (myArray[i] > Max) Max = myArray[i];
        else if (myArray[i] < Min) Min = myArray[i];
    }
    return Max - Min;
}

double[] myArray = GetArray(5);
Console.WriteLine(string.Join(" ", myArray.Select(n => $"{n:F2}")));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива : {Diff(myArray):f2}");






