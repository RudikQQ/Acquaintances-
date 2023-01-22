// Задача 10: Напишите программу, которая 
// 1.принимает на вход трёхзначное число и на 
// 2.выходе показывает вторую цифру этого числа. 
// 3.Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


int ShowSecondDigit(int num)
{
   
    int num1 = num / 10;
    int num3 = num1 % 10;
    return num3;
}


Console.Write("Введите трёзначное число ");
int numOne = Convert.ToInt32(Console.ReadLine());
int res = ShowSecondDigit(numOne);

if(numOne > 100 && numOne < 999)
{
    Console.WriteLine($"{numOne} -> {res}");
}
else 
{
    Console.WriteLine($"{numOne} -> число не трёхзначное");
}

