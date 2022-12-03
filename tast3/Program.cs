// See https://aka.ms/new-console-template for more information
int a,counter;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
counter = a*-1;
while (counter<= a)
{
    Console.Write(counter + " ");
    counter++; 
}