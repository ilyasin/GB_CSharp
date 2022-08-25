/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

using System.Text;

string Task23(int number) {
    StringBuilder stringBuilder = new StringBuilder();

    for (int i = 1; i <= number; i++) {
        stringBuilder.Append($"{i * i * i} ");
    }
    return stringBuilder.ToString().Trim();
}

System.Console.WriteLine(Task23(3));
System.Console.WriteLine(Task23(5));