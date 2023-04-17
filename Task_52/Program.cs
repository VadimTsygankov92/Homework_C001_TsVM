// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column_num = int.Parse(Console.ReadLine()!);


int[,] array = FillAray(row_num, column_num);
PrintArray(array);
Console.Write($"Среднее арифметическое каждого столбца: ");
FindArithmeticMean(array);


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

void FindArithmeticMean(int[,] array)
{
  int row = array.GetLength(0);
  int column = array.GetLength(1);
  double sum = 0;
  for (int j = 0; j < column; j++)
  {
    for (int i = 0; i < row; i++)
    {
      sum = sum + array[i, j];
    }
    sum = sum / array.GetLength(0);
    Console.Write($" {Math.Round(sum, 1)} ");
    sum = 0;
  }
}


