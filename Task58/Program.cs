// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max) 
{
    int[,] matrix1 = new int[rows, columns]; 
    Random rnd = new Random(); 
    
    for (int i = 0; i < matrix1.GetLength(0); i++)   
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix1;
}

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max) 
{
    int[,] matrix2 = new int[rows, columns]; 
    Random rnd = new Random(); 
    
    for (int i = 0; i < matrix2.GetLength(0); i++)   
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix2;
}

void PrintMatrix1(int[,] matrix1) 
{
    for (int i = 0; i < matrix1.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
               Console.Write($"{matrix1 [i, j], 4}"); 
        }
        Console.WriteLine(); 
    }
}

void PrintMatrix2(int[,] matrix2) 
{
    for (int i = 0; i < matrix2.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
               Console.Write($"| {matrix2[i, j], 4}"); 
        }
        Console.WriteLine(); 
    }
}

 boll MultiplyMatrix (int matrixCreate)
{if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        double[,] result = MatrixCreate(matrix1.GetLength(0), matrix2.GetLength(1));
    }
return false;
}
    

void MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
       for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        result[i,j] += matrix1[i,k] * matrix2[k,j];
      }
    }
  }
}

int[,] matrix1 = CreateMatrixRndInt1(3, 4, -10, 10); 
int[,] matrix2 = CreateMatrixRndInt2(3, 4, -10, 10); 

PrintMatrix1(matrix1); 
Console.Write("||");
PrintMatrix2(matrix2); 
Console.WriteLine(); 
MultiplyMatrix(result); 