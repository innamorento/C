// See https://aka.ms/new-console-template for more information
int a,remdevision;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    remdevision = i % 2;
    if (remdevision == 0)
    {
        Console.Write (i + " ");
    }
}



