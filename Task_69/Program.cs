﻿//Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8

int myNumberA = 3;
int myNumberB = 5;

int PowAtoB (int a, int b) // метод  возведения А в B
{
  if (b==0) return 1; // условие выхода из рекурсии, когда степень будет равна 0
  return a * PowAtoB(a, b-1); // умножаем наше число А на то что осталось до тех пор,пока степень не будет равна 0.
}

Console.WriteLine(PowAtoB(myNumberA,myNumberB));