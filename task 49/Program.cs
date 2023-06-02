// Задача 49: Задайте двумерный массив.
//  Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

void ReplaceToSquare(int[,] matrix)
{
    // for (int i = 0; i < matrix.GetLength(0); i += 2)
    // {
    //     for (int j = 0; j < matrix.GetLength(1); j += 2)
    //     {
    //         matrix[i, j] *= matrix[i, j]; 
    //     }
    // }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j]; 
            }
        }
    }
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
ReplaceToSquare(matrix);
PrintMatrix(matrix);