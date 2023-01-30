// Задача 38: 
// 1.Задайте массив вещественных чисел. 
// 2.Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)        //Заполнение массива вещественными числами
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)       // вывод заполнение массива вещественными числами
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


double MaxElement(double[] massiv)
{
    double max = massiv[0];
    for (int i = 0; i < massiv.Length; i++)
    {
        if (max < massiv[i]) max = massiv[i];
    }
    return max;
}

double MinElement(double[] massiv)
{
    double min = massiv[0];
    for (int i = 0; i < massiv.Length; i++)
    {
        if (min > massiv[i]) min = massiv[i];
    }
    return min;
}

double DifferenceElemens(double min, double max)
{
    double difference = Math.Round(max - min, 1, MidpointRounding.ToZero);
    return difference;
}


double[] arr = CreateArrayRndDouble(10, 0, 100);
PrintArrayDouble(arr);
double maxEle = MaxElement(arr);
double minEle = MinElement(arr);
double diff = DifferenceElemens(minEle, maxEle);
Console.Write(" -> ");
Console.Write(diff);









