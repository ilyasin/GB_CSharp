using System.Collections;


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

    for (int i = 0; i < rows; i++) {
        int rowSum = 0;
        for (int j = 0; j < cols; j++) {
            rowSum += array[i, j];
        }
        if (minSum > rowSum) minSum = rowSum;
        result = i;
    }  

    return result;
}


int[,] matrix = GetArray(3, 3);
PrintArray(matrix);
System.Console.WriteLine();

System.Console.WriteLine(GetMinSumRowIndex(matrix));

//PrintArray(GetSortRows(matrix));