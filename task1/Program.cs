// See https://aka.ms/new-console-template for more information

int a,b;
Console.WriteLine("Введите 2 числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a*a == b)
{
    Console.WriteLine(b + " является квадртаом " + a);

}
else
{
    Console.WriteLine(b + " НЕ является квадртаом " + a);    
}