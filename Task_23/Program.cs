/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите число: ");
int Number = int.Parse(Console.ReadLine());
if (Number <= 0)
{
  Console.WriteLine("Вы ввели число 0 или меньше нуля!");
}
else
{
  for (int i = 1; i < Number; i++)
  {
    Console.Write($"{i * i * i}, ");
  }
  Console.Write($"{Number * Number * Number}");
}



