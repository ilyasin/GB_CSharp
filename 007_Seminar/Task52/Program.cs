/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void PrintArray(int[,] array) {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            System.Console.Write($"{array[i, j]} ");    
        }
        System.Console.WriteLine();
    }
}

int[,] GetArray(int m, int n) {
    int[,] result = new int [m, n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            result[i, j] = new Random().Next(100);
        }
    }

    return result;
}

void getAvgCols(int[,] array) {
    double avg;
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    for (int i = 0; i < cols; i++) {
        avg = 0;
        for (int j = 0; j < rows; j++) {
            avg += array[j, i];
        }
        avg /= rows;
        System.Console.Write($"{avg} ");
    }
    System.Console.WriteLine();
}


int[,] matrix = GetArray(5, 5);
PrintArray(matrix);
System.Console.WriteLine();
getAvgCols(matrix);

System.Console.WriteLine();
int[,] example = new int[,] {{1, 4, 7, 2},
                             {5, 9, 2, 3},
                             {8, 4, 2, 4}};

PrintArray(example);
getAvgCols(example);
