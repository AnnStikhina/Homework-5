// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] getArray(int size, int min, int max)
{
    Console.Write("Массив: ");
    double[] locArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        locArray[i] = new Random().Next(min, max + 1);
    }
    foreach (int i in locArray)
    {
        Console.Write($" {i} ");
    }
    Console.WriteLine();
    return locArray;
}

double Max(double[] lArray)
{
    double max = lArray[0];
    for (int i = 0; i < lArray.Length; i++)
    {
        if (lArray[i] > max) max = lArray[i];
    }
    return max;
}

double Min(double[] lArray)
{
    double min = lArray[0];
    for (int i = 0; i < lArray.Length; i++)
    {
        if (lArray[i] < min) min = lArray[i];
    }
    return min;
}

double[] array = getArray(8,0,15);

Console.WriteLine($"Макс: {Max(array)}; Мин: {Min(array)}; Разница: {Max(array) - Min(array)}");

