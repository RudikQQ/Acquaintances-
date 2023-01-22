// Задача 22: Напишите программу, которая
// 1.принимает на вход число (N) и 
// 2.выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());


void SquareTable(int number) 
{

int count = 1;


while (count <= number)
{
    Console.WriteLine($"|{count} | {Math.Pow(count, 2)}|");
    count++;
}
}
SquareTable(number);

