Console.Clear();

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
}
int max = array[0];
int min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
    if (min > array[i])
    {
        min = array[i];
    }
}
int decision = max - min;
Console.WriteLine($"\nРазница между между максимальным -> {max} и минимальным -> {min} элементами массива = {decision}");