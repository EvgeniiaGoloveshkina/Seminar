// Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]



Console.Write("Введите количество элементов массива N: ");
int col=int.Parse(Console.ReadLine());
Console.Write("Введите число a: ");
int numA=int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int numB=int.Parse(Console.ReadLine());

int[] InitArray()
{
    int[] arr=new int[col];
    for (int i=0;i<arr.Length;i++)
    {
        arr[i]=new Random().Next(numA,numB);
    }
    return arr;
}
void ReadArray(int [] arr)
{
     for (int i=0;i<arr.Length;i++)
     {
        Console.Write($"{arr[i]},  ");      
     }
     Console.WriteLine();
} 

Console.WriteLine(String.Join(" , ",InitArray()));  

