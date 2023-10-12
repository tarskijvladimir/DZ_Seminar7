// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Напимер , задан массив:
// 1    3   5    7
// 9   11 13 15
// 17 19 21 23
// 17  -> такого числа нет в массиве
// 11 -> 11

using System;

public class Answer {
    public static void PrintArray(int[,] matrix) {
        int m = matrix.GetLength(0); // получение количества строк
        int n = matrix.GetLength(1); // получение количества столбцов

        // вывод массива на консоль
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                Console.Write($"{matrix[i, j]}\t"); // добавление символа табуляции для более читаемого вывода
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k) {
        int[,] matrix = new int[n, m]; // создание двумерного массива

        int value = 1; // начальное значение элемента

        // заполнение массива значениями, увеличивающимися на k с каждым новым элементом
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                matrix[i, j] = value;
                value += k;
            }
        }

        return matrix;
    }

    public static int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition) {
        int n = matrix.GetLength(0); // количество строк
        int m = matrix.GetLength(1); // количество столбцов

        if (rowPosition < 0 || rowPosition >= n || columnPosition < 0 || columnPosition >= m) {
            return new int[] { 0 }; // если элемент находится за пределами массива, возвращаем массив с нулевым значением
        } else {
            return new int[] { matrix[rowPosition, columnPosition], 0 }; // возвращаем массив с значением элемента и нулевым значением для обозначения успешного выполнения операции
        }
    }

    public static void PrintCheckIfError(int[] results, int X, int Y) {
        if (results.Length == 1) {
            Console.WriteLine("There is no such index"); // вывод сообщения об отсутствии элемента
        } else {
            Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}"); // вывод значения элемента
        }
    }

    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        } else {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
            x = 2;
            y = 3;
        }

        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}

