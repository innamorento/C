// See https://aka.ms/new-console-template for more information
int a,b;
Console.WriteLine("Введите 2 числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine(a + " больше" + b);

}
else if (a == b)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine(b + " больше " + a);    
}