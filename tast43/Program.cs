float calculationx(int b1, int b2, int k1, int k2)
{
    return (float)(b2-b1)/(k1-k2);
}

float calculationy(int b, int k, float x)
{
    return (float)(k*x)+b;
}
Console.WriteLine("Введите b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые паралеьные");
}
else
{
    float x = calculationx(b1,b2,k1,k2);
    float y1 = calculationy(b1,k1,x);
    float y2 = calculationy(b2,k2,x);
    Console.WriteLine($"x =  {x}");
    Console.WriteLine($"Координаты пересечения прямых находятсяв точке {y1} {y2}");
}
