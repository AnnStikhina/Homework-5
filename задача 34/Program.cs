// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.

int[] getArray(int size, int min, int max)
{
    Console.Write("Массив: ");
    int[] locArray = new int[size];

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

int ShowEven(int[] lArray)
{
    int count = 0;

    for (int i = 0; i < lArray.Length; i++)
    {
        if (lArray[i] % 2 == 0) count = count + 1;        
    }
    return count;
}

Console.WriteLine($"Количество чётных чисел в массиве: {ShowEven(getArray(8, 100, 999))}");
