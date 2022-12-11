// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите Х");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите У");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 & y >0)
{
    Console.WriteLine("Координаты принадлежат 2 четверти");
}
else if (x > 0 & y <0)
{
   Console.WriteLine("Координаты принадлежат 4 четверти");
}
else if (x < 0 & y <0)
{
   Console.WriteLine("Координаты принадлежат 3 четверти");
}
else if (x < 0 & y >0)
{
   Console.WriteLine("Координаты принадлежат 1 четверти");
}
else
{
    Console.WriteLine("Указано не верное значение");
}