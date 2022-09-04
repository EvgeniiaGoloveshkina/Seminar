// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
           
    }
  
    return res;
}
 int EvenNumberes(int[] myAray) 
 {
    int count = 0;
    foreach (int el in myAray) 
    {
        if (el % 2 == 0) count++;
    }
    return count;
 }

int[] myArray = GetArray(10, 100, 1000);
Console.WriteLine(String.Join(" ", myArray)); 
Console.WriteLine(EvenNumberes(myArray));