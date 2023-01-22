// Задача 13: Напишите программу, которая 
// 1.выводит третью цифру заданного числа или 
// 2.сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}


Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int res = ThirdDigit(number);
if(number > 100 )
{
    Console.WriteLine($"{number} -> {res}");
}
else 
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}







