// Задача 50. 
// 1.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// 2.возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");

        }


        Console.WriteLine("|");
    }
}


Console.Write("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int colums = Convert.ToInt32(Console.ReadLine());



int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);

if (rows < array2D.GetLength(0) && colums < array2D.GetLength(1)) Console.WriteLine($"{array2D[rows, colums]} елемент есть");
else Console.WriteLine($"{rows} , {colums} -> такого элемента в массиве нет");

PrintMatrix(array2D);
Console.WriteLine(" ");
CreateMatrixRndInt(3, 4, 1, 100);
