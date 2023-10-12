// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3.6; 3


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

    static void PrintListAvr(double[] list) {
        Console.Write("The averages in columns are: ");
        for (int i = 0; i < list.Length; i++) {
            Console.Write($"{list[i]:F2}\t"); // вывод среднего арифметического для каждого столбца с округлением до двух знаков после запятой
        }
    }

    static double[] FindAverageInColumns(int[,] matrix) {
        int n = matrix.GetLength(0); // количество строк
        int m = matrix.GetLength(1); // количество столбцов

        double[] columnAverages = new double[m]; // создание массива для хранения средних значений

        for (int j = 0; j < m; j++) {
            int sum = 0;
            for (int i = 0; i < n; i++) {
                sum += matrix[i, j]; // суммирование элементов столбца
            }
            columnAverages[j] = (double)sum / n; // нахождение среднего арифметического и сохранение в массиве
        }

        return columnAverages;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}
