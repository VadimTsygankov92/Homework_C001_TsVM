// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int rowNumber = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columnNumber = int.Parse(Console.ReadLine()!);


int[,] array = FillMatrix(rowNumber, columnNumber);
PrintMatrix(array);
SortToLower(array);
PrintMatrix(array);



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
      array[i, j] = new Random().Next(1, 10);

  return array;
}

void SortToLower(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}