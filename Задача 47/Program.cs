// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами
// M=3, n=4
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;

public class Answer {
  public static double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
      double[,] matrix = new double[m, n]; // создание двумерного массива

      Random random = new Random(); // создание объекта для генерации случайных чисел

      // заполнение массива случайными вещественными числами
      for (int i = 0; i < m; i++) {
          for (int j = 0; j < n; j++) {
              matrix[i, j] = random.NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom; // генерация случайного числа в заданных границах
          }
      }

      return matrix;
  }

  public static void PrintArray(double[,] matrix) {
      int m = matrix.GetLength(0); // получение количества строк
      int n = matrix.GetLength(1); // получение количества столбцов

      // вывод массива на консоль
      for (int i = 0; i < m; i++) {
          for (int j = 0; j < n; j++) {
              Console.Write($"{matrix[i, j]:f2}\t"); // интерполяция строк для форматирования числа с двумя знаками после запятой и добавления символа табуляции
          }
          Console.WriteLine();
      }
  }

  // Не удаляйте и не меняйте метод Main! 
  public static void Main(string[] args) {
    int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4) {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

        // Выберем случайные индексы трех элементов матрицы array
        int row1 = new Random().Next(0, m);
        int col1 = new Random().Next(0, n);
        int row2 = new Random().Next(0, m);
        int col2 = new Random().Next(0, n);
        int row3 = new Random().Next(0, m);
        int col3 = new Random().Next(0, n);

        // Проверяем, являются ли выбранные элементы дробными числами
        bool isFractional1 = (array[row1, col1] % 1) != 0;
        bool isFractional2 = (array[row2, col2] % 1) != 0;
        bool isFractional3 = (array[row3, col3] % 1) != 0;

        // Если два из трех элементов не являются дробными числами, то бросаем исключение
        if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
        {
            Console.WriteLine("Все ок!");
        }
        else
        {
            throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
        }
    } else {
      m = 3;
      n = 4;
      minLimitRandom = -10;
      maxLimitRandom = 10;
      
      double[,] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
    }
  }
}

