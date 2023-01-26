// Задача 29: Напишите программу, которая 
// 1.задаёт массив из 8 элементов и 
// 2.выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] arr = CreateArray(8);
PrintArray(arr); Console.Write("-> "); Console.Write("["); PrintArray(arr); Console.Write("]");

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1, 9);
    }
    return array;
}


void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        
        if (i == 7)
        {
            Console.Write($"{array[i]} ");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}

