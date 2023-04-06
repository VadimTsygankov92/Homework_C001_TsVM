// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = GetIntInput();
Console.WriteLine($"Сумма чисел: {AmountDigits(number)}");

int GetIntInput()
{
  string input = Console.ReadLine();
  int result = int.Parse(input);
  return result;
}

int AmountDigits(int a)
{
  int sum = 0;
  int b = 0;
  while (a >= 10)
  {
    b = a % 10;
    sum = sum + b;
    a = a / 10;
  }
  if (a < 10)
  {
    sum = sum + a;
  }
  return sum;
}

