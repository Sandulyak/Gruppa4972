System.Console.WriteLine("Введите два числа");
int numA = int.Parse(Console.ReadLine()??"0");
int numB = int.Parse(Console.ReadLine()??"0");

if(numB*numB == numA)
{
   System.Console.WriteLine("Первое число квадрат второго");
}
else
{
   System.Console.WriteLine("Первое число не квадрат второго");
}