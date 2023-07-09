// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
{
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random(); 
    
    for (int i = 0; i < matrix.GetLength(0); i++)   
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
               Console.Write($"{matrix[i, j], 5}"); 
        }
        Console.WriteLine(); 
    }
}

void SumRows(int[,] matrix)
{
    int[] sumRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRows[i] += matrix[i, j];
        }
    }    
    int minSumRows = 0;
            for (int i = 0; i < sumRows.Length; i++)
            {
                if (sumRows[minSumRows] > sumRows[i]) minSumRows = i;
            }
    Console.Write($"Наименьшая сумма элементов: {sumRows[minSumRows]}, номер строки с ней: {minSumRows + 1}");
}

int[,] matrix = CreateMatrixRndInt(3, 4, -10, 10); 

PrintMatrix(matrix); 
Console.WriteLine();
SumRows(matrix);
