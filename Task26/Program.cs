// Задача 26: Напишите программу, которая 
// 1.принимаетн на вход число и 
// 2,выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int countNumber = CountNumber(number);
Console.WriteLine($"{number} -> {countNumber}");

int CountNumber(int num)
{
    if (num < 0) num = num * -1;
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}