﻿//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

//int sum = 0;
//void SumOfNumbers(int n)
//{
//    if (n / 10 > 0)
//    {
//        SumOfNumbers(n / 10);
//    }
//    sum += n % 10;
//}
//SumOfNumbers(45);
//System.Console.WriteLine(sum);

int myNumber = 453;
Console.WriteLine(SumDigits(myNumber));// печатаем на экран результат работы нашего метода SumDigits

int SumDigits(int number)
{
  if (number==0) return 0;
  return number % 10 + SumDigits(number / 10);
}