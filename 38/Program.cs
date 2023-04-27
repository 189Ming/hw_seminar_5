// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{round}, ");
        else Console.Write($"{round}");
    }
}

double MinElem(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(min > arr[i])
        min = arr[i];
    }
    return min;
}

double MaxElem(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(max < arr[i])
        max = arr[i];
    }
    return max;
}


double[] array = CreateArrayRndDouble(5, 0, 100);
Console.Write("[");
PrintArray(array);
Console.WriteLine("]");

Console.Write("Minimal element = ");
double min = MinElem(array);
min = Math.Round(min, 1);
Console.WriteLine(min);

Console.Write("Maximal element = ");
double max = MaxElem(array);
max = Math.Round(max, 1);
Console.WriteLine(max);

double result = max - min;
result = Math.Round(result, 1);
Console.WriteLine($"Difference between numbers = {result}");

// подумал, что отдельный метод для разницы смотрится лишним.