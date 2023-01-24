// Задача 23.

// Напишите программу, 
// 1.которая принимает на вход число (N) и 
// 2.выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());


void SquareTable(int number)
{

    int count = 1;
    
     while (count <= number)
    {
        Console.WriteLine($"|{count} | {Math.Pow(count, 3)}|");
        count++;
    }
}
SquareTable(number);