﻿
//int GetNum(){
//Console.Write("Введите число: ");
//return Convert.ToInt32(Console.ReadLine());
//}

//int firstNum = GetNum();
//int secondNum = GetNum();

//bool firstPow = firstNum == Math.Pow(secondNum, 2);
//bool secondPow = secondNum == Math.Pow(firstNum, 2);


//Console.WriteLine(firstPow || secondPow ? "Одно из чисел является квадратом второго" : "Ни одно из чисел не является квадратом другого");



//int numA = int.Parse (Console.ReadLine()??"0");
//int numB = int.Parse (Console.ReadLine()??"0");
//bool test1 = (numA == numB*numB);
//bool test2 = (numB == numA*numA);

//if (test1) Console.WriteLine ("Первое квадрат второго");
//if (test2) Console.WriteLine ("второе квадрат первого");
//if (!(test1||test2))
//{
//Console.WriteLine ("Числа не квадраты друг друга");
//}


int a = int.Parse(Console.ReadLine()??"0");
int b = int.Parse(Console.ReadLine()??"0");

bool test1 = a == b*b;
bool test2 = b == a*a;

if(test1){
Console.WriteLine("Первое квадрат второго");
}else if(test2){
Console.WriteLine("Второе квадрат первого");
}else{
Console.WriteLine("Одно не является квадратом другого");
}