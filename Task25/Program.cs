// Задача 25: Напишите цикл, который 
// 1.принимает на вход два числа (A и B) и 
// 2.возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень ");
int degree = Convert.ToInt32(Console.ReadLine());
int degreeNumber = DegreeNumber(number, degree);
CheckingDegree(degree);

void CheckingDegree(int num)
{
    if (degree > 0)
    {
        Console.WriteLine(number + " в степени " + degree + " = " + degreeNumber);
    }
    else
    {
        Console.WriteLine($"степень {degree} должна быть натуральным числом");
    }
}


int DegreeNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;

}