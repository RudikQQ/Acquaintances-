// Задача 58: 
// 1.Задайте две матрицы. 
// 2.Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }

}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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



void MultiplyMatrix(int[,] oneMatrixGenerate, int[,] twoMatrixGenerate, int[,] resultMatrix)
{
    if (resultMatrix.GetLength(0) != oneMatrixGenerate.GetLength(1))
        {
            Console.WriteLine(" матрица не квадратная  ");
            return;
        }
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < oneMatrixGenerate.GetLength(1); k++)
            {
                sum += oneMatrixGenerate[i, k] * twoMatrixGenerate[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
int[,] oneMatrixGenerate = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(oneMatrixGenerate);
Console.WriteLine("");
int[,] twoMatrixGenerate = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(twoMatrixGenerate);
Console.WriteLine("произведение двух матриц");
MultiplyMatrix(oneMatrixGenerate, twoMatrixGenerate, matrix);
PrintMatrix(matrix);



