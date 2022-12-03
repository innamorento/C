bool FounNomberinArrey(int[] ArrayForFound, int numberforsearch)
{
    
    for (int i = 0; i < ArrayForFound.Length; i++)
    {
       if (ArrayForFound[i] == numberforsearch)
       {
            return true;
       } 
    }
    return false;
}
int n = Convert.ToInt32(Console.ReadLine());
int[] holiday ={6,7};
int[] workday ={1,2,3,4,5};
if (n > 0 & n < 8)
{
    //itsworkday = FounNomberinArrey(workday, n);
    bool itsholiday = FounNomberinArrey(holiday, n);
    if (itsholiday)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий");
    }
}
else
{
    Console.WriteLine("Нет такого дня");
}
