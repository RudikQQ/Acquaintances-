// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

Fibonacci(number);
void Fibonacci(int num)
{
    int first = 0, second = 1;
    Console.Write($"Если N = {number} -> {first} {second} ");
    for (int i = 2; i < number; i++)
    {
        int newNumber = first + second;
        Console.Write($"{newNumber} ");
        first = second;
        second = newNumber;
    }
}