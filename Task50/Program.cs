// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int rows = 0; int columns = 0; 

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

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100); 
PrintMatrix(array2d);


    if (rows < 0 | rows > matr.GetLength(0) - 1 | columns < 0 | columns > matr.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", matrix[rows, columns]);
}

