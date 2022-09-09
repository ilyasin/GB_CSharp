/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

вводим позиции по i и j -> если таких нет - выводим, что позиции не существует. Если есть - выводим элемент по этим индексам.
*/

int[,] GetArray(int m, int n) {
    int[,] result = new int [m, n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            result[i, j] = new Random().Next(100);
        }
    }

    return result;
}

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

int GetElementByIndexes(int[, ] matrix, int row, int col) {
    if (row < matrix.GetLength(0) && row >=0 && col < matrix.GetLength(1) && col >= 0) {
        return matrix[row, col];
    }
    else {
        System.Console.WriteLine("Такого числа в массиве нет");
        return -1;
    }
}

int[,] matrix = GetArray(5, 5);
PrintArray(matrix);
System.Console.WriteLine();
System.Console.WriteLine(GetElementByIndexes(matrix, 4, 4));
System.Console.WriteLine(GetElementByIndexes(matrix, 6, 6));
System.Console.WriteLine(GetElementByIndexes(matrix, -1, 4));
