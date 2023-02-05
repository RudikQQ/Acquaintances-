// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// // 3 -> 11


Console.WriteLine("Введите десятичное число: ");                                 
int number = Convert.ToInt32(Console.ReadLine());

string Binary(int num)                                                        //Через строку
{  
    string res = string.Empty;
    while (num > 0)
    {
        res = num % 2 + res;
        num = num / 2;

    }
    return res;
}

string binary = Binary(number);
Console.Write($"{number} -> {binary}");