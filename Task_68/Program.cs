//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 9

int m = 1;
int n = 3; 

Console.Write($"A({m}, {n}) = {functionAkkerman(m, n)}");

int functionAkkerman(int firstNumber, int secondNumber)
{
  if (firstNumber == 0)
    return secondNumber + 1;
  
  if (firstNumber > 0 && secondNumber == 0)
    return functionAkkerman(firstNumber - 1, 1);

  else
    return functionAkkerman(firstNumber - 1, functionAkkerman(firstNumber, secondNumber - 1));
}

//firstNumber
//secondNumber
//if (firstNumber > 0 && secondNumber > 0)

//int Akkerman(int m, int n)
//{
//    if (m == 0)
//        return n + 1;
//    if (m > 0 && n == 0)
//        return Akkerman(m - 1, 1);
//    else
//        return Akkerman(m - 1, Akkerman(m, n - 1));
//}