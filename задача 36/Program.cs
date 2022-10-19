// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих на
// нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] LocArray (int size, int min, int max)
{
    int[] array = new int [size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
        return array;
    }

}
int FindSum (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (1 % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

Console.WriteLine("Введите длину масива: ");
int n = int.Parse(Console.ReadLine()!);
int[] arr = LocArray(n, -10, 10);
FindSum(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {FindSum(arr)}");
Console.WriteLine(String.Join(",", arr));

