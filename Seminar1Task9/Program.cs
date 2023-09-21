
Console.WriteLine("Способ 1");

System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(10,100);
Console.WriteLine(number);


int firstDigit = number/10;

int secondDigit = number%10;

if (firstDigit>secondDigit)
{
    Console.WriteLine(firstDigit);
}

else
{
    Console.WriteLine(secondDigit);
}

Console.WriteLine("Способ 2");

System.Random numberGenerator1 = new System.Random();
int number1 = numberGenerator1.Next(10,100);
Console.WriteLine(number1);

Console.WriteLine((number/10>number%10)?(int)(number/10):(int)(number%10));
