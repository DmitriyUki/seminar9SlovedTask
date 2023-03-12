//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int m = 11;
int n = 15;
Console.WriteLine($"Сумма элементов = {CountNaturalSum(m, n)}");

int CountNaturalSum(int m, int n)
{
    if (m == n) return n;
    int count = n + CountNaturalSum(m, n - 1);
    return count;
}