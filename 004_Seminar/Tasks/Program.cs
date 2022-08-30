/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Task25(int a, int b) {
    int result = a;
    for (int i = 2; i <= b; i++) {
        result *= a;
    }
    return result;
}

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int Task27(int number) {
    int sum = 0;
    while (number > 0) {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void Task29(int number) {
    int[] array = new int[number];
    for (int i = 0; i < number; i++) {
        array[i] = new Random().Next();
    }
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

//System.Console.WriteLine(Task25(3, 5));
//System.Console.WriteLine(Task25(2, 4));
//System.Console.WriteLine(Task27(452));
//System.Console.WriteLine(Task27(82));
//System.Console.WriteLine(Task27(9012));
//Task29(8);