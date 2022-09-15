/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

void Task64(int m, int n) {
    if (m == n) {
        System.Console.WriteLine($"{m} ");
    }
    else {
        System.Console.Write($"{m} ");
        Task64(m + 1, n);
    }
}

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Task66(int m, int n) {
    if (m == n) {
        return m;
    }
    else {
        return m + Task66(m + 1, n);
    }
}

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29
*/


int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Task64(1, 5);
System.Console.WriteLine(Task66(4, 8));
System.Console.WriteLine(Akkerman(3, 2));
