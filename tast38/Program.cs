int[] generationrandomarray()
{
    Console.WriteLine($"Введите размер массива");
    int arraylength = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите начало диапазона случайных чисел");
    int randombegin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите конец диапазона случайных чисел");
    int randomend = Convert.ToInt32(Console.ReadLine());
    int[] ramdomarray = new int[arraylength];
    for (int i = 0; i < arraylength; i++)
    {
        Random rnd = new Random();
        ramdomarray[i] = rnd.Next(randombegin,randomend);
    }
    return ramdomarray;
}

int maxelement(int[] arraynumbers)
{
    int max = arraynumbers[0];
    for (int i = 1; i < arraynumbers.Length; i++)
    {
        if (arraynumbers[i]>max)
        {
            max = arraynumbers[i];
        }
    }
    return max;
}

int minelement(int[] arraynumbers)
{
    int min = arraynumbers[0];
    for (int i = 1; i < arraynumbers.Length; i++)
    {
        if (arraynumbers[i]<min)
        {
            min = arraynumbers[i];
        }
    }
    return min;
}


void printarray(int[] arrayforprint)
{
    for (int i = 0; i < arrayforprint.Length; i++)
    {
        Console.Write($"{arrayforprint[i]} ");
    }
    Console.WriteLine();
}

int[] newarray = generationrandomarray();
int max = maxelement(newarray);
int min = minelement(newarray);
printarray(newarray);
 Console.Write($"Разница между {max} и {min} = {max-min} ");