int n = new Random().Next(10,100);

int secondnumber = n%10;
int firstnumber = n/10;
if (firstnumber > secondnumber) 
{
    Console.WriteLine(firstnumber);
}
else
{
    Console.WriteLine(secondnumber) ;
}