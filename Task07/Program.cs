// Напишите программу, 
// которая принимает на вход трехзначное число и на 
// выходе показывает послднюю цифру этого числа.

Console.WriteLine("Введите трехначное целое число "); //ввод текста
int number = Convert.ToInt32(Console.ReadLine());
int res = number % 10;
Console.WriteLine($"Последняя цифра {res}");


