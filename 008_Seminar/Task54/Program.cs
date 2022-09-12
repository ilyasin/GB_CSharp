void PrintArray(int[,] array) {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            System.Console.Write($"{String.Format("{0:D2}", array[i, j])} ");    
        }
        System.Console.WriteLine();
    }
}

int[,] GetArray(int m, int n) {
    int[,] result = new int [m, n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            result[i, j] = new Random().Next(0, 10);
        }
    }

    return result;
}

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
int[,] GetSortRows(int[,] array) {
    int[,] result = array;
    int rows = result.GetLength(0);
    int cols = result.GetLength(1);
    
    for (int i = 0; i < rows; i++) {
        // sorting
        for (int j = 0; j < cols; j++) {
            for (int k = 0; k < cols - j - 1; k++) {
                if (result[i, k] < result[i, k + 1]) {
                    int temp = result[i, k];
                    result[i, k] = result[i, k + 1];
                    result[i, k + 1] = temp;
                }
            }
        }
    }

    return result;
}

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int GetMinSumRowIndex(int[,] array) {
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int minSum = 0;
    int result = 0;

    for (int j = 0; j < cols; j++) {
        minSum += array[0, j];
    }

    for (int i = 1; i < rows; i++) {
        int rowSum = 0;
        for (int j = 0; j < cols; j++) {
            rowSum += array[i, j];
        }
        if (minSum > rowSum) {
            minSum = rowSum;
            result = i;
        }
    }  

    return result;
}

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] Multi(int[,] a, int[,] b) {
    int rowsA = a.GetLength(0);
    int colsA = a.GetLength(1);
    int rowsB = b.GetLength(0);
    int colsB = b.GetLength(1);

    int[,] result = new int[rowsA, colsB];

    if (colsA != rowsB) {
        System.Console.WriteLine("Матрицы не могут быть перемножены");
        return result;
    }

    for (int r = 0; r < colsA; r++) {
        for (int i = 0; i < rowsA; i++) {
            for (int j = 0; j < colsB; j++) {
                result[i, j] += a[i, r] * b[r, j];
            }
        }
    }   

    return result;
}

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
void PrintThreeDim(int[,,] array) {
    int len1 = array.GetLength(0);
    int len2 = array.GetLength(1);
    int len3 = array.GetLength(2);

    for (int i = 0; i < len1; i++) {
        for (int j = 0; j < len2; j++) {
            for (int k = 0; k < len3; k++) {
                System.Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            System.Console.WriteLine();
        }
    }
}

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
int[,] GetSpiral(int n) {
    int[,] result = new int[n, n];
    int value = 1;

    for (int r = 0; r < n / 2; r++) {
        for (int i = r; i < n - r; i++) {
            result[r, i] = value;
            value++;
        }
        for (int i = r + 1; i < n - r; i++) {
            result[i, n - r - 1] = value;
            value++;
        }
        for (int i = n - r - 2; i >= r; i--) {
            result[n - r - 1, i] = value;
            value++;
        }
        for (int i = n - r - 2; i > r; i--) {
            result[i, r] = value;
            value++;
        }
    }
    return result;
}


int[,] matrix = GetArray(3, 3);
PrintArray(matrix);
System.Console.WriteLine();

System.Console.WriteLine(GetMinSumRowIndex(matrix));

//PrintArray(GetSortRows(matrix));

/*
int[,] a = {{2, 4}, {3, 2}};
int[,] b = {{3, 4}, {3, 3}};

PrintArray(Multi(a, b));*/

//int[,,] array3 = {{{1,2},{3,4}},{{5,6},{7,8}}};

//PrintThreeDim(array3);

//PrintArray(GetSpiral(4));