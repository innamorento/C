int sumnumbers()
{
    Console.WriteLine("Введите стоп слово для завершения ввода ряда чисел");
    string strstopwod = Console.ReadLine();
    int sum = 0;
    bool exit = true; 
    while (exit)
    {
        Console.WriteLine($"Введите число или слово {strstopwod} для завершения ввода чисел");
        string temp = Console.ReadLine();
        if (temp ==  strstopwod)
        {
            exit = false;
        }
        else if ( Convert.ToInt32(temp) > 0)

        {
           sum += Convert.ToInt32(temp); 
        }
    }
    return sum;
}

 Console.WriteLine($"Сумма положительных чисел =  {sumnumbers()}");