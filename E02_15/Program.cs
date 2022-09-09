int number1 = new Random().Next(1, 7);
Console.WriteLine(number1);

if(number1 >= 6)
{
    Console.WriteLine("выходной");
}
else
{
     Console.WriteLine("рабочий");
}
Console.ReadKey();

