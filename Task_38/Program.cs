// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[5];
FillArray(array);
PrintArray(array);
int result = FindMax(array) - FindMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна: {result}");

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1, 100);
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

int FindMin(int[] array)
{
  int min = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] <= min)
    {
      min = array[i];
    }
  }
  return min;
}

int FindMax(int[] array)
{
  int max = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] >= max)
    {
      max = array[i];
    }
  }
  return max;
}
