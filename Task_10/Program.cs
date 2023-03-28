//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5 782 -> 8 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
if (number < 100 || number > 999)
{
  Console.WriteLine("Вы ввели не трехзначное число");
} else
{
int secondNumber = (number / 10) % 10;
 Console.WriteLine(secondNumber);
}