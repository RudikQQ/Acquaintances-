// Задача 34:
// 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int QuantityEvenNumbers(int[] massive)
{
    int result = 0;
    for (int i = 0; i < massive.Length; i++)
    {
         if (massive[i] % 2 == 0)

            result++;
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

int[] mass = CreateArrayRndInt(4, 100, 999);
int quantityEvenNumbers = QuantityEvenNumbers(mass);
PrintArray(mass);
Console.WriteLine($" ->  Четных чисел {quantityEvenNumbers}");


