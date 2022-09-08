// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int CountPositive(int[] myArray)
{
  int count = 0;
  for (int i = 0; i < myArray.Length; i++)
  {
    if ( myArray[i] > 0) count += 1; 
  }
  return count;
}

int[] InputNumber(int number)
{
    int[] result = new int[number];
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"Введите {i+1} число:  ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
} 

Console.Write("Введите количество чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Чисел больше нуля введено:  {CountPositive(InputNumber(num))}");

