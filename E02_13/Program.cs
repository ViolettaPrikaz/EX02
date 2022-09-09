int number1 = new Random().Next(50, 200);
Console.WriteLine(number1);

if(number1 > 99)
{
    Console.WriteLine(number1.ToString()[2]);
}
else
{
     Console.WriteLine("третьей цифры нет");
}
Console.ReadKey();

