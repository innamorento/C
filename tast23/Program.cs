// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= x; i++)
{
    Console.Write($" Число {i} в кубе = {i*i*i} ");
}