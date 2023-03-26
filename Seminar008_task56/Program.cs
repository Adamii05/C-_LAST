using System;

class Program {
  public static void Main (string[] args) {

    Console.WriteLine("Введите количество строк: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] array = GetArray(rows, columns, 0, 10);
          PrintArray(array);

    Console.WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");

    int[,] GetArray(int m, int n, int min, int max)
    {
      int[,] result = new int[m, n];
      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          result[i, j] = new Random().Next(min, max +1);
        }
      }
      return result;
    }
    void PrintArray(int[,] array)
    {
      for (int i = 0; i < array.GetLength(0); i++)
      {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
      }
    }
    int GetRowNumber (int [,] array)
    {
      int row = 0;
      int minsum = 0;
      for (int i = 0; i < array.GetLength(1); i++)
      {
        minsum = minsum + array[0,i];
      }

      for (int i = 1; i < array.GetLength(0); i++)
      {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
          sum = sum + array[i,j];
        }
        if (minsum > sum)
        {
          minsum = sum;
          row = i;
        }
      }
      return row;
    }
           
            
            
                         
  }
}
