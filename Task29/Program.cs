// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

int[] arr = new int[8]; 
FillArray(arr); 
Console.Write("["); 
PrintArray(arr); 
Console.Write("]"); 

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
} 

void FillArray(int[] array)
{
    var rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 9);
    }
    return;
}



