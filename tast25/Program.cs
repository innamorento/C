Console.WriteLine("Введите число");
string str = Console.ReadLine();
int x = Convert.ToInt32(str);


int[] arrayofnumbers(int number, int numberlengf)
{
    int[] arreynumbers = new int[numberlengf];
    int strlength = numberlengf -1;
    int multiplier = 1;
    for (int i = 1; i <= numberlengf; i++)
    {
        int temp = (number / multiplier) % 10;
        multiplier = multiplier * 10;
        arreynumbers[strlength] = temp;
        strlength--;
    }
    return arreynumbers;
}


void printarray(int[] arrayforprint)
{
    for (int i = 0; i < arrayforprint.Length; i++)
    {
        Console.Write($"{arrayforprint[i]} ");
    }
    Console.WriteLine();
}

int summallelementsofarray(int[] arrayforsumm)
{
    int sum = 0;
    for (int i = 0; i < arrayforsumm.Length; i++)
    {
        sum += arrayforsumm[i];
    } 
    return sum;
}
int[] temp = arrayofnumbers(x, str.Length);
printarray(temp);
Console.WriteLine($"сумма всех цифр в числе = {summallelementsofarray(temp)}");