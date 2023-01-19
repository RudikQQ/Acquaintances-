// 16. Напишите программу, которая 
// 1.принимает навход два числа и 
// 2.проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

bool isSquare = IsSquare(numOne, numTwo);
Console.Write(isSquare ? "да" : "нет");

bool IsSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}

