Console.Clear();

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 
Console.Write($"Введите количество элементов массива: ");
int count = Convert.ToInt32(Console.ReadLine()); 
int RndNum(int count, int min, int max)
{
  int[] array = new int[count];
  int sum = 0;
  Console.Write("Массив: ");

    for (int i = 0; i <array.Length; i++ )
    {
      array[i] = new Random().Next(min, max);

      Console.Write(array[i] + " ");

      if (i % 2 != 1)
      {
        sum = sum + array[i];
      }
    }
  return sum;
}

int rndnum =  RndNum(count, 1, 10);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {rndnum}");


