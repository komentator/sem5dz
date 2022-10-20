// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] FillArray(int length, int minLimit, int maxLimit)
{
    double[] collection = new double[length];
    Random rand = new Random();
    for(int i = 0; i < collection.Length; i++) collection[i] = rand.Next(minLimit, maxLimit) + rand.NextDouble(); // Генерируем случайное число и вещественний "хвостик" после запятой
    return collection;
}

double FindMaxMin (double[] array, int fl = 1) // Добавляем флаг. По умолчанию 1, если параметр не был передан.
{
    double number = array[0];
    for(int index = 0; index < array.Length; index++)
    {
        if (array[index] * fl > number * fl) // Положительные станут отрицательными, отрицательные положительными при fl = -1.
        {
            number = array[index];
        }
    }
    return number;
}

void PrintArray(double[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
        Console.Write($"{col[position]:f2}\t");
}

double[] array = FillArray(12, -100, 100); // Вводим длину массива, минимальное и максимальное значение чисел в массиве.
Console.WriteLine("Наш массив:");
PrintArray(array);
double max = FindMaxMin(array);
double min = FindMaxMin(array, -1);
Console.WriteLine($"\nРазница между максимальным и минимальным элементами массива: {max:f2} - {min:f2} = {(max - min):f2}");
