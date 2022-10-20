/* Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
*/
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

int CountOf(int[] randomArray)
{
    int count = 0;
    for(int index = 0; index < randomArray.Length; index++)
    {
        if (randomArray[index] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] array = FillArray(12, 100, 999); // Вводим длину массива, минимальное и максимальное значение чисел в массиве.
Console.WriteLine("Наш массив:");
PrintArray(array);
Console.WriteLine($"\nКоличество четных чисел в массиве: {CountOf(array)}");
