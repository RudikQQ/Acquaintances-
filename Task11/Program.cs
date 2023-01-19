// 11.Напишите программу, 
// 1.которая выводит случайное трехзначное число и 
// 2.удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98



int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число из отрезка 100-999 -> {number}");

int res = RemoveSecondDigit(number);
Console.WriteLine($"удаляем вторую цифру -> {res}");
int RemoveSecondDigit(int num) 
{
   int num1 = num / 100;
   int num3 = num % 10;
   int result1 = num1 * 10 + num3;
   return result1;
}
