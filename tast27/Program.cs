Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите в какую степень возвести число");
int degree = Convert.ToInt32(Console.ReadLine());

int mypow(int x, int y)
{
    int result = 1;
    for (int i = 1; i <= y; i++)
    {
        result = result * x;
    }
    return result;
}

Console.WriteLine($"число {number} в степени {degree} = {mypow(number, degree)}");