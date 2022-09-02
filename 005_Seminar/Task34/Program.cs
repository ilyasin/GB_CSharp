/*
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
System.Console.Write($"[{string.Join(", ", array)}] -> ");
System.Console.WriteLine(countEven(array));
System.Console.WriteLine(countEven(new int[]{345, 897, 568, 234}));