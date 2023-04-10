// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в массиве равно: {CheckEvenNumbers(array)}");

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
}

void PrintArray(int[] array)
{
  Console.Write("[");
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write($"{array[i]}, ");
  }
  Console.WriteLine(array[^1] + "]");
}

int CheckEvenNumbers(int[] array)
{
  int counter = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      counter++;
    }
  }
  return counter;
}