int SumNaturalNumbersInInterval(int startInterval, int stopInterval, int sum)
{
    
    if (startInterval >  stopInterval) return sum;
 
    else
    {
        //sum = sum + startInterval;
        sum = SumNaturalNumbersInInterval(startInterval +1, stopInterval, sum + startInterval);
    }
    return sum;
}
int sum = 0;
Console.WriteLine("Введите начало интервала");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец интервала");
int finish = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"Сумма натуральных чисел в интервале от {start} до {finish} = {SumNaturalNumbersInInterval(start, finish, sum)}");
