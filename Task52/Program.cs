// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

double[] arr = new double[matrix.GetLength(1)]; 
for (int j = 0; j < matrix.GetLength(1); j++)
{
    int sum = 0; 
    for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j]; 
        }
    arr[j] = sum / matr.GetLength(0);   
     Console.WriteLine($"Среднее арифметическое элементов {sum}"); 
}
//return arr;

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100); 
PrintMatrix(array2d);

Console.WriteLine("Введите число строк "); 
int rows2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число столбцов "); 
int columns2 = Convert.ToInt32(Console.ReadLine());

