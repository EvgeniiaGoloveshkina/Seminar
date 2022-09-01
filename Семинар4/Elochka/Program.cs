//Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.

Console.Write("Введите высоту елочки: ");
int height=int.Parse(Console.ReadLine());          
            
int probel = height;
for (int i = 0, j = 1; i < height; i++, j+=2)
{
                
    Console.Write(new string(' ',probel--));
    Console.Write(new string('*',j));
    Console.WriteLine();
 }
       