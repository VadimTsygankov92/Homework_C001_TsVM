// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество элементов в массиве: ");
int[] array = new int[ReadNumberFromConsole()];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 в массиве равно: {CheckNumbersMoreThanZero(array)}");


int ReadNumberFromConsole()
{
  string input = Console.ReadLine();
  return int.Parse(input);
}

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.WriteLine("Введите цифру: ");
    array[i] = ReadNumberFromConsole();
  }
}

int CheckNumbersMoreThanZero(int[] array)
{
  int counter = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
      counter++;
    }
  }
  return counter;
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