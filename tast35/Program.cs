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

int numberbelongstotherange(int[] arraynumbers)
{
    Console.WriteLine($"Введите начало диапазона в которое должно входить число");
    int numberbelongstart = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите конец диапазона в которое должно входить число");
    int numberbelongend = Convert.ToInt32(Console.ReadLine());
    int counter = 0;
    for (int i = 0; i < arraynumbers.Length; i++)
    {
        if (arraynumbers[i] > numberbelongstart & arraynumbers[i] < numberbelongend) 
        {
            counter ++;
        }
    }
    return counter;
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
printarray(newarray);
Console.WriteLine($"Четных чисел принадлежащих диапазону {numberbelongstotherange(newarray) }");