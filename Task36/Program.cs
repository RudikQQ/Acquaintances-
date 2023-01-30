// Задача 36: 
// 1.Задайте одномерный массив, заполненный случайными числами. 
// 2.Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



int SumOddPositions(int[] massive)
{
    int result = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += massive[i];
        }
    }
    return result;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] massive)
{
    Console.Write("[");
    for (int i = 0; i < massive.Length; i++)
    {
        if (i < massive.Length - 1) Console.Write($"{massive[i]}, ");
        else Console.Write($"{massive[i]}");
    }
    Console.Write("]");
}

int[] mass = CreateArrayRndInt(5, 0, 999);
int sumOddPositions = SumOddPositions(mass);
PrintArray(mass);
Console.WriteLine($" -> {sumOddPositions}");