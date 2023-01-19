// 12. Напишите программу, которая 
// 1.будет принимать навход два числа и 
// 2.выводить, является ли первое число
// кратным второму. 
// 3.Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.Write("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());


void Multiplicity(int arg1, int arg2)
{
    if (arg1 % arg2 == 0)
        Console.WriteLine($"{numOne}, {numTwo} -> кратно ");
    else
        Console.WriteLine($" {numOne}, {numTwo} -> не кратно, остаток {arg1 % arg2}");
}

Multiplicity(numOne, numTwo);



