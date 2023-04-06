// Задача 29: Напишите программу, которая приниматет на вход длину массива, 
// минимальное значение массива и максимальное значение массива, создаёт массив с заданными параметрами и выводит значения на экран
// 5, 1, 19 -> [1, 2, 5, 7, 19]
// 3, 1, 33 -> [6, 1, 33]

Console.Clear();

Console.WriteLine("Введите длину массива: ");
int arrayLength = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число: ");
int max = int.Parse(Console.ReadLine());

int[] array = new int[arrayLength];
FillArray(array, min, max);
PrintArray(array);

void FillArray(int[] a, int b, int c)
{
  for (int i = 0; i < a.Length; i++)
  {
    array[i] = new Random().Next(b, c + 1);
  }
}

void PrintArray(int[] array)
{

  int i = 0;
  Console.Write("[");
  while (i < array.Length - 1)
  {
    Console.Write($"{array[i]}, ");
    i++;
  }
  Console.Write($"{array[i]}]");
}
