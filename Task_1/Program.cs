Console.Clear();

// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int[] array = new int [10];
Random random = new Random();
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
    Console.Write($"{array[i]}, ");

    if (array[i] % 2 == 0)
        {
        count += 1;
        }
}
Console.WriteLine($"в данном массиве чётных чисел -> {count}.");