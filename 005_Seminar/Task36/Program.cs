/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] createArray(int length) {
    int[] array = new int [length];

    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next();
    }
    return array;
}

int getSumOddPos(int[] array) {
    int result = 0;
    for (int i = 1; i < array.Length; i+=2) {
        result += array[i];
    } 
    return result;
}

int[] array = createArray(5);
System.Console.Write($"[{string.Join(", ", array)}] - > ");
System.Console.WriteLine(getSumOddPos(array));
System.Console.WriteLine(getSumOddPos(new int[]{3, 7, 23, 12}));
System.Console.WriteLine(getSumOddPos(new int[]{-4, -6, 89, 6}));