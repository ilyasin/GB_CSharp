﻿/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int[] createArray(int length) {
    int[] array = new int [length];

    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

int countEven(int[] array) {
    int countEven = 0;
    foreach (int number in array) {
        if (number % 2 == 0) countEven++;
    }

    return countEven;
}

int[] array = createArray(5);
System.Console.WriteLine($"[{string.Join(", ", array)}]");
System.Console.WriteLine(countEven(array));


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/