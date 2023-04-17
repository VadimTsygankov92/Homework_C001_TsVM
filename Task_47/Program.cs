// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int rowNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columnNumber = int.Parse(Console.ReadLine()!);

double[,] array = FillArray(rowNumber, columnNumber);
PrintArray(array);

void PrintArray(double[,] arr)
{
  int row = arr.GetLength(0);
  int column = arr.GetLength(1);

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < column; j++)
      Console.Write($" {arr[i, j]}");
    Console.WriteLine();
  }
  Console.WriteLine();
}

double[,] FillArray(int row, int column)
{
  double[,] array = new double[row, column];

  for (int i = 0; i < row; i++)
    for (int j = 0; j < column; j++)
      array[i, j] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 1);
  return array;
}

