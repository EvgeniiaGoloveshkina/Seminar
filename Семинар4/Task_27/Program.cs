// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11   82 -> 10   9012 -> 12

int Summa(int amount)
{
    int result=0;
    while (amount!=0)
    {
       result+=amount%10;
       amount=amount/10;
    }
    return result;
}
Console.Write("Введите число: ");
int col=int.Parse(Console.ReadLine());
Console.WriteLine($"{Summa(col)}");
