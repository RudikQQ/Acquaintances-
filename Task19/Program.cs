// Задача 19
// Напишите программу, которая 
// 1.принимает на вход пятизначное число и 
// 2.проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да



int CheckPalindrom(int number)
{
    int result = -1;
    if (number >= 10000 && number <= 99999 )
    {
        int div1 = number / 10000;
        int rem1 = number % 10;

        if (div1 == rem1)
        {
            number = number / 10;
            int div2 = (number / 100) % 10;
            int rem2 = number % 10;
            if (div2 == rem2)
                Console.WriteLine("Да");
        }
        else
            Console.WriteLine("Нет");

    }
    else
        Console.WriteLine("Некорректное число!");
        return result;
}

Console.Write("Введите пятизначное число :  ");
int number = Convert.ToInt32(Console.ReadLine());
int res = CheckPalindrom(number);


