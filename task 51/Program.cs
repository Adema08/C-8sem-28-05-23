// Задача 51: Задайте двумерный массив.
//  Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void FillMatrixWithNumbers(int[,] matrix)
{
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
}

int FindSumDiagonalNumbers(int[,] matrix)
{
    int sumOfDiagonalNumbers = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sumOfDiagonalNumbers += matrix[i, i];
    }
    return sumOfDiagonalNumbers;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} " + "\t");
        }
        System.Console.WriteLine();
    }
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrixWithNumbers(matrix);
PrintMatrix(matrix);
Console.WriteLine(" ");
Console.Write($"Сумма элементов с одинаковыми индексами: {FindSumDiagonalNumbers(matrix)}");