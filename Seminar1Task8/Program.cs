Console.WriteLine("Введите число:");
//Прием данных
int N = Convert.ToInt32(Console.ReadLine());

//Создание счетчика
int count = 0;

//Проверка на четность
if (N % 2 != 0)
{
    //Делаем число четным
    N = N - 1;
}

while (count < N)
{
    //Увеличение и вывод счетчика
    count = count + 2;
    Console.Write(count + " ");
}