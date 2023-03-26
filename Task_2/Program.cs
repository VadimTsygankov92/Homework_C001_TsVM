Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
  Console.WriteLine("Максимальное число: ");
  Console.WriteLine(number1);
  Console.WriteLine("Минимальное число: ");
  Console.WriteLine(number2);
} else
{
  Console.WriteLine("Максимальное число: ");
  Console.WriteLine(number2);
  Console.WriteLine("Минимальное число: ");
  Console.WriteLine(number1);
}


