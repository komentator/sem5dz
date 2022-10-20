// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int length, int minLimit, int maxLimit)
{
    int[] collection = new int[length];
    for(int i = 0; i < collection.Length; i++) collection[i] = new Random().Next(minLimit,maxLimit + 1);
    return collection;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
        Console.Write($"{col[position]}\t");
}

int OddIndexSum (int[] array)
{
    int sum = 0;
    for(int index = 1; index < array.Length; index += 2)
    {
        sum += array[index];
    }
    return sum;
}

int[] array = FillArray(6, 0, 9); // Вводим длину массива, минимальное и максимальное значение чисел в массиве.
Console.WriteLine("Наш массив:");
PrintArray(array);
Console.WriteLine($"\nСумма чисел, стоящих на нечетных позицицях: {OddIndexSum(array)}");
Footer
© 2022 GitHub, Inc.