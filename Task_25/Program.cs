// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите первое число: ");
int firstNumber = GetIntInput();
Console.WriteLine("Введите второе число: ");
int secondNumber = GetIntInput();
Console.WriteLine($"Число {firstNumber} в натуральной степени числа {secondNumber} будет {RaiseNatDegree(firstNumber, secondNumber)}");

int GetIntInput()
{
  string input = Console.ReadLine();
  int result = int.Parse(input);
  return result;
}

int RaiseNatDegree(int a, int b)
{
  int result = a;
  for (int i = 1; i < b; i++)
  {
    result = result * a;
  }
  return result;
}

