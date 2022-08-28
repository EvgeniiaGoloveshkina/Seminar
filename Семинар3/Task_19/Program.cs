// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Строки и массивы использовать нельзя!
// 14212 -> нет    12821 -> да            23432 -> да


Console.Write("Введите пятизначное число:  ");                   
int num=int.Parse(Console.ReadLine());         
int fifth=num/10000;
int first=num%10;
int fourth=num/1000%10;
int second=num%100/10;

if (fifth==first && fourth==second)
{
    Console.Write("Да");
}
else
{
      Console.Write("Нет");
}