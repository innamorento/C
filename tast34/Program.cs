// See https://aka.ms/new-console-template for more information

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

int counterevennumbers(int[] arraynumbers)
{
    int countnumbers = 0;
    for (int i = 0; i < arraynumbers.Length; i++)
    {
        if (arraynumbers[i]%2 ==0)
        {
            countnumbers ++;
        }
    }
    return countnumbers;
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
Console.WriteLine($"Четных чисел в массиве {counterevennumbers(newarray) }");