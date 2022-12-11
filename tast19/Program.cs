Console.WriteLine("Введите пятизначное число");
string str = Console.ReadLine();
int x = Convert.ToInt32(str);
int multiplier = 1;
int[] numbers = new int[str.Length];
int strlength = str.Length -1; //Используем длинну строи для загрузи в массив
for (int i = 1; i <= str.Length; i++)
{ 
    int temp = (x/multiplier)%10;
    multiplier = multiplier * 10;
    numbers[strlength] = temp;
    strlength --; 
}
int strlength2 = str.Length -1; //Используем длинну строи для сравнения чисел  в массиве
bool polindrom = false;
for (int i = 0; i < str.Length; i++)
{
    if (numbers[i] == numbers[strlength2])
    {
        Console.WriteLine($" Число {numbers[i]} Число {numbers[strlength2]} ");
        polindrom = true;
    }
    else
    {
        polindrom = false;
        break;
    }
    strlength2 --;
}
if (polindrom == true)
{
    Console.WriteLine($" Число {x} полиндром");
}
else
{
    Console.WriteLine($" Число {x} не полиндром");
}
