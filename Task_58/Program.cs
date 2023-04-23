// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine()!);




int[,] arrayFirst = FillMatrix(row, column);
int[,] arraySecond = FillMatrix(row, column);
int[,] resultArray = new int[row, column];
PrintMatrix(arrayFirst);
PrintMatrix(arraySecond);

if (arrayFirst.GetLength(0) != arraySecond.GetLength(1))
{
  Console.WriteLine("Эти матрицы нельзя перемножить! ");
}
for (int i = 0; i < arrayFirst.GetLength(0); i++)
{
  for (int j = 0; j < arraySecond.GetLength(1); j++)
  {
    resultArray[i, j] = 0;
    for (int k = 0; k < arrayFirst.GetLength(1); k++)
    {
      resultArray[i, j] = resultArray[i, j] + arrayFirst[i, k] * arraySecond[k, j];
    }
  }
}

PrintMatrix(resultArray);


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
