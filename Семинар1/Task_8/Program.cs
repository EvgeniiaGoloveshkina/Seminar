Console.Write("Введите число: ");
int num=int.Parse(Console.ReadLine());
int current=2;
    
while (current<=num)
{ 
   if (current%2==0)
    {
         Console.Write($"{current} ");
    }    
       current++; 
    
    }
