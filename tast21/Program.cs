// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите 3 координаты 1 точки");
int firstx = Convert.ToInt32(Console.ReadLine());
int firsty = Convert.ToInt32(Console.ReadLine());
int firstz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 координаты 2 точки");
int secondx = Convert.ToInt32(Console.ReadLine());
int secondy = Convert.ToInt32(Console.ReadLine());
int secondz = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(secondx - firstx,2) + Math.Pow(secondy - firsty,2)+ Math.Pow(secondz - firstz,2));
Console.Write($" Расстояние между точками  {result} ");