// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Позиция элемента в строке: ");
int rowPosition = int.Parse(Console.ReadLine()!);
Console.Write("Позиция элемента в стобце: ");
int columnPosition = int.Parse(Console.ReadLine()!);

int[,] mass = FillAray(row_num, column_num);
PrintArray(mass);
FindElement(mass, rowPosition, columnPosition);

void PrintArray(int[,] array)
{
  int row_size = array.GetLength(0);
  int column_size = array.GetLength(1);

  for (int i = 0; i < row_size; i++)
  {
    for (int j = 0; j < column_size; j++)
      Console.Write($" {array[i, j]} ");
    Console.WriteLine();
  }
  Console.WriteLine();
}

int[,] FillAray(int row, int column)
{
  int[,] array = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      array[i, j] = new Random().Next(1, 10);

  return array;
}

void FindElement(int[,] array, int rowNumber, int columnNumber)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == rowNumber - 1 && j == columnNumber - 1)
      {
        Console.WriteLine($"Этот элемент равен: {array[i, j]}");
        return;
      }
      else if (rowNumber > array.GetLength(0) || columnNumber > array.GetLength(1) || rowNumber == 0 || columnNumber == 0)
      {
        Console.WriteLine("Такого элемента в массиве нет!");
        return;
      }

    }
  }
}

