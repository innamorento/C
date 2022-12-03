// See https://aka.ms/new-console-template for more information
int a,b, c, localmax;
Console.WriteLine("Введите 3 числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    localmax = a;

}
else 
{
     localmax = b;
}
if (localmax < c)
{
    localmax = c;    
}

Console.WriteLine("Максимальное число " + localmax);