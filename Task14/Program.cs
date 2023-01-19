// Андрей Булгаков: 14. Напишите программу, 
// 1.которая принимает навход число и 
// 2.проверяет, кратно ли оноодновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int numOne = Convert.ToInt32(Console.ReadLine());

bool mult = Multiplicity(numOne);
Console.Write(mult ? "да" : "нет");

bool Multiplicity(int num1)
{
    return num1 % 7 == 0 && num1 % 23 == 0;

}

