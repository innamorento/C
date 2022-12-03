int n = new Random().Next(100,1000);

int thirdnumber = n/100;
int firstnumber = n%10;
Console.WriteLine("Число " + n);
int result =  thirdnumber*10+firstnumber;
Console.WriteLine(result) ;
