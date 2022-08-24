// Написать программу, которая  принимает на вход цифру, обозначающей день недели и
//проверяет является ли этот день недели выходным
// 3->нет; 6-> да

Console.WriteLine("Введите число(день недели)");
int day=int.Parse(Console.ReadLine());
if (0<day&&day<8)
{
    if (day==1) Console.WriteLine("Понедельник");
    else if (day==2) Console.WriteLine("Вторник");
    else if (day==3) Console.WriteLine("Среда");
    else if (day==4) Console.WriteLine("Четверг");
    else if (day==5) Console.WriteLine("Пятница");
    else if (day==6) Console.WriteLine("Суббота");
    else if (day==7) Console.WriteLine("Воскресенье");
    if (day==6||day==7) Console.WriteLine("Выходной день");
    else  Console.WriteLine("День-не выходной");
}
else
{
    Console.WriteLine("Не правильный день недели");

}
