/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int Task10(int number) => (number % 100) / 10;

System.Console.WriteLine(Task10(456));
System.Console.WriteLine(Task10(782));
System.Console.WriteLine(Task10(918));

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

string Task13(int number) {
    if (number < 100) {
        return "третьей цифры нет";
    }
    int k = (int)Math.Log10(number) - 2;
    int result = number % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k);

    return result.ToString();
}

System.Console.WriteLine(Task13(645));
System.Console.WriteLine(Task13(78));
System.Console.WriteLine(Task13(32679));


/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

string Task15(int number) => number == 6 || number == 7 ? "да" : "нет";

System.Console.WriteLine(Task15(6));
System.Console.WriteLine(Task15(7));
System.Console.WriteLine(Task15(1));
System.Console.WriteLine(Task15(2));