/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число: ");
int Number = int.Parse(Console.ReadLine());

int number1 = Number / 10000;
int number2 = Number / 1000 % 10;
int number4 = Number / 10 % 10;
int number5 = Number % 10;
if (Number < 10000 || Number > 99999)
{
  Console.WriteLine("Вы ввели не пятизначное число!");
}
else if (number1 == number5 && number2 == number4)
{
  Console.WriteLine("Да, число является палиндромом!");
}
else
{
  Console.WriteLine("Нет, число не является палиндромом!");
}