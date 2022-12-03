// See https://aka.ms/new-console-template for more information
int a,remdevision;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
remdevision = a%2;
if (remdevision == 0)
{
   Console.WriteLine("Число четное"); 
}
else
{
    Console.WriteLine("Число не четное"); 
}

