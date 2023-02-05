// Задача 15: Напишите программу, 
// 1.которая принимает на вход цифру, обозначающую день недели, и 
// 2.проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int num = Weekend(number);

int Weekend(int number)
{
    num = 1;
    if (number < 8)

    if (number == 1)
    {
        Console.WriteLine($"{number} -> Нет");
    }
    else if (number == 2)
    {
        Console.WriteLine($"{number} -> Нет");
    }
    else if (number == 3)
    {
        Console.WriteLine($"{number} -> Нет");
    }
    else if (number == 4)
    {
        Console.WriteLine($"{number} -> Нет");
    }
    else if (number == 5)
    {
        Console.WriteLine($"{number} -> Нет");
    }
    else if (number == 6)
    {
        Console.WriteLine($"{number} -> Да");
    }
    else if (number == 7)
    {
        Console.WriteLine($"{number} -> Да");
    }
    else
        Console.WriteLine("Введите число в диапозоне от 1-7");
    return num;
}


