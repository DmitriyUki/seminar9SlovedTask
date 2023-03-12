//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int n = 10;
const int m = 1;

Console.WriteLine(Print1ToN(n, m));

int Print1ToN(int n, int m)
{
    if (n <= m) return n;
    Console.Write($"{Print1ToN(n, m + 1 )}, "); 
    return m;
}


