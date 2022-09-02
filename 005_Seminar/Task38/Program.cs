/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] createArray(int length) {
    double[] array = new double [length];

    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().NextDouble();
    }
    return array;
}

double getMaxMinDiff(double[] array) {
    double max = array[0];
    double min = array[0];

    foreach (double element in array) {
        if (max < element) max = element;
        if (min > element) min = element;
    }
    return Math.Abs(max - min);
}

double[] array = createArray(5);
System.Console.Write($"[{string.Join(", ", array)}] -> ");
System.Console.WriteLine(getMaxMinDiff(array));
System.Console.WriteLine(getMaxMinDiff(new double[]{3, 7, 22, 2, 78}));