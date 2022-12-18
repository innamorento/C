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

int sumoddelement(int[] arraynumbers)
{
    int sum = 0;
    for (int i = 1; i < arraynumbers.Length; i+=2)
    {
        sum += arraynumbers[i];
    }
    return sum;
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
Console.WriteLine($"Сумма нечетных элементов = {sumoddelement(newarray)}");