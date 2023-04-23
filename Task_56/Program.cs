// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int rowNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columnNumber = int.Parse(Console.ReadLine()!);


int[,] array = FillMatrix(rowNumber, columnNumber);
PrintMatrix(array);
int[] arraySumNumbersInRow = FindSumNumbersInRow(array);
int minRow = FindMin(arraySumNumbersInRow);
Console.WriteLine($"Наименьшая сумма элементов в строке номер: {minRow}");


void PrintMatrix(int[,] array)
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

int[,] FillMatrix(int row, int column)
{
  int[,] array = new int[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      array[i, j] = new Random().Next(1, 3);

  return array;
}

int[] FindSumNumbersInRow(int[,] array)
{
  int[] arr = new int[array.GetLength(0)];
  int row = array.GetLength(0);
  int column = array.GetLength(1);
  int sum = 0;
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
    {
      sum = sum + array[i, j];
      arr[i] = sum;
    }
    sum = 0;
  }
  return arr;
}


int FindMin(int[] array)
{
  int min = array[0];
  int row = 1;
  for (int i = 0; i < array.Length; i++)
  {
    if (min > array[i])
    {
      min = array[i];
      row = i + 1;

    }
  }
  return row;
}
