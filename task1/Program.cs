// See https://aka.ms/new-console-template for more information

int a,b;
Console.WriteLine("Введите 2 числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());

if (a == b*b)
{
    Console.WriteLine(a + " является квадртаом " + b);

}
else
{
    Console.WriteLine(a + " НЕ является квадртаом " + b);    
}