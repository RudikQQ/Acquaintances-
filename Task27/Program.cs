// Задача 27: Напишите программу, которая 
// 1.принимает на вход число и 
// 2.выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int numberlen = NumberLen(number);
int sumnumbers = SumNumbers(number, numberlen);
CheckNumbers(number);

void CheckNumbers ( int number)
{
    if (number >= 0)
    {
        Console.WriteLine(sumnumbers);
    }
    else
    {
        Console.WriteLine("Введите натуральное число");
    }
}

int NumberLen(int a)
    {
        int index = 0;
        while (a > 0)
        {
            a /= 10;
            index++;
        }
        return index;
    }


int SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    return sum;
    Console.WriteLine($"сумма цифр {sum}");
}
