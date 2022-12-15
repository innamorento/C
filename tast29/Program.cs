
int[] createnewarray()
{
    Console.WriteLine("Введите размер массива");
    int arraysize = Convert.ToInt32(Console.ReadLine());
    int[] newarray = new int[arraysize];
    for (int i = 0; i < arraysize; i++)
    {
        Console.WriteLine($"Введите {i} элемент массива");
        newarray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newarray;
}

void printarray(int[] arrayforprint)
{
    for (int i = 0; i < arrayforprint.Length; i++)
    {
        Console.Write($"{arrayforprint[i]} ");
    }
    Console.WriteLine();
}

//int[] newarray = createnewarray(); 
printarray(createnewarray()); 