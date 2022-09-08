/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void PrintArray(double[,] array) {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            System.Console.Write($"{array[i, j]} ");    
        }
        System.Console.WriteLine();
    }
}

double[,] GetArray(int m, int n) {
    double[,] result = new double [m, n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            result[i, j] = new Random().NextDouble();
        }
    }

    return result;
}

PrintArray(GetArray(3, 3));
