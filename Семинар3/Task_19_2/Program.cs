// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет    12821 -> да            23432 -> да

int num=new Random().Next(10000,100000) ;            
Console.WriteLine(num );    
int fifth=num/10000;
int first=num%10;
int fourth=num/1000%10;
int second=num%100/10;

if (fifth==first && fourth==second)
{
    Console.WriteLine("Да");
}
else
{
      Console.WriteLine("Нет");
}