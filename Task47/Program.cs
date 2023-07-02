// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
{
    int rows = 0; int columns = 0;
    double[,] matr = new double[rows, columns]; 
    Random rnd = new Random(); 
    int min = 0; int max = 0; 
    for (int i = 0; i < matrix.GetLength(0); i++)   //rows=arr.GetLength(0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.NextDouble() * 100;
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
               Console.Write($"{matrix[i, j], 3}"); 
        }
        Console.WriteLine(); 
    }
}

Console.WriteLine("Введите число строк "); 
int rows2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число столбцов "); 
int columns2 = Convert.ToInt32(Console.ReadLine());

double[,] twoDimArray = CreateMatrixRndInt(3, 4, -100, 100); 
PrintMatrix(twoDimArray);
